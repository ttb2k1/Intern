using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DTO
{
    class DTO_NhanVien
    {
        public string TenNhanVien { get; set; }
        public string MaNhanVien { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }
    }
}
