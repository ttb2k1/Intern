using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DTO
{
    class DTO_HoaDonVe
    {
        string MaHoaDonVe { get; set; }
        string MaSuatChieu { get; set; }
        string MaGhe { get; set; }
        DateTime NgayBanVe { get; set; }
        string MaNhanVien { get; set; }
        float GiaVe { get; set; }
        string MaKhachHang { get; set; }
        public DTO_HoaDonVe(string mhdv, string msc, string mg, DateTime nbv, string mnv, float gv, string mkh)
        {
            MaHoaDonVe = mhdv;
            MaSuatChieu = msc;
            MaGhe = mg;
            NgayBanVe = nbv;
            MaNhanVien = mnv;
            GiaVe = gv;
            MaKhachHang = mkh;
        }
    }
}
