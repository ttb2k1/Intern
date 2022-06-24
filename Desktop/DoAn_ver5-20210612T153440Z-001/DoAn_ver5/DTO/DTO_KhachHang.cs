using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DTO
{
    class DTO_KhachHang
    {
        public string MaKH { get; set; }
        public string TenKhachHang { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string LoaiKhachHang { get; set; }
        public DateTime NgayDangKy { get; set; }
    }
}
