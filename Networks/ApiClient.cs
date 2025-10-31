using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using computer_monitoring_desktop.Utils;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace computer_monitoring_desktop.Networks
{
    public sealed class ApiClient
    {
        private static readonly Lazy<ApiClient> _instance =
            new Lazy<ApiClient>(() => new ApiClient());

        private readonly HttpClient _client;

        private const string BASE_URL = "https://localhost:7118/api/";
        private const int TIMEOUT_SECONDS = 30;

        public static ApiClient Instance => _instance.Value;

        private readonly ILogger<ApiClient> _logger =
            LoggerProvider.CreateLogger<ApiClient>();

        private ApiClient()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(BASE_URL)
            };
            _client.Timeout = TimeSpan.FromSeconds(TIMEOUT_SECONDS);
        }

        private void AttachToken()
        {
            if (!string.IsNullOrEmpty(AppHttpSession.Token))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", AppHttpSession.Token);
            }
        }

        public async Task<T?> GetAsync<T>(string endpoint)
        {
            AttachToken();
            var response = await _client.GetAsync(endpoint);
            return await HandleResponse<T>(response);
        }

        public async Task<T?> PostAsync<T>(string endpoint, object data)
        {
            AttachToken();
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _logger.LogInformation("POST {Endpoint} with payload: {Payload}", endpoint, json);
            var response = await _client.PostAsync(endpoint, content);
            return await HandleResponse<T>(response);
        }

        private async Task<T?> HandleResponse<T>(HttpResponseMessage response)
        {
            string body = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<T>(body);

            Console.WriteLine($"[API ERROR] {response.StatusCode}: {body}");
            return default;
        }
    }
}
