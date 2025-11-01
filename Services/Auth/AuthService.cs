using computer_monitoring_desktop.Dtos;
using computer_monitoring_desktop.Networks;
using computer_monitoring_desktop.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_monitoring_desktop.Services.Auth
{
    public class AuthService
    {
        private readonly ILogger<AuthService> _logger;

        public AuthService()
        {
            _logger = LoggerProvider.CreateLogger<AuthService>();
        }
        public async Task<LoginResponse?> LoginAsync(LoginRequest req)
        {
            _logger?.LogInformation("Attempting to log in user with email: {Email} - password: {Password}", req.email, req.password);
            return await ApiClient.Instance.PostAsync<LoginResponse>("Auth/login", req);
        }
    }
}
