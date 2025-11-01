using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_monitoring_desktop.Models.Violation
{
    internal class ViolationRecord
    {
        public int Id { get; set; }
        public string MaSV { get; set; } = "";
        public string LoaiViPham { get; set; } = "";
        public string MoTa { get; set; } = "";
        public string MucDo { get; set; } = "";
        public string TrangThai { get; set; } = "";
        public DateTime ThoiGian { get; set; }
    }
}
