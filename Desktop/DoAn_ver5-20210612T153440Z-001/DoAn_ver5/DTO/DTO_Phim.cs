using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DTO
{
    public class DTO_Phim
    {
        public string MaPhim {get;set;}
        public string TenPhim { get; set; }
        public string ThoiLuong { get; set; }
        public string NhaSanXuat { get; set; }
        public string NamSanXuat { get; set; }
        public string NgonNgu { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public string NuocSanXuat { get; set; }
        public double DoanhThu { get; set; }
        public string CacDienVien { get; set; }
        public bool TrangThai { get; set; }
        public string MoTa { get; set; }

        public DTO_Phim()
        {

        }
        public DTO_Phim(DataRow row)
        {
            MaPhim = row["MaPhim"].ToString();
            TenPhim = row["TenPhim"].ToString();
        }
    }

}
