using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.DTO;
using DoAn_ver5.BLL;

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class DoanhThu_KhoangThoiGianControl : UserControl
    {
        private static DoanhThu_KhoangThoiGianControl _instance;
        public static DoanhThu_KhoangThoiGianControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DoanhThu_KhoangThoiGianControl();
                return _instance;
            }
        }
        public DoanhThu_KhoangThoiGianControl()
        {
            InitializeComponent();
        }

        //List<DTO_HoaDonVe> list = BLL_HoaDonVe.Instance.GetListHoaDonVe();

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (cbbTenPhim.SelectedItem == null) return;
            string TenPhim = cbbTenPhim.SelectedItem.ToString();
            DateTime Tu_Ngay = dtpTuNgay.Value;
            string TuNgay = Tu_Ngay.Date.ToString("yyyy/MM/dd");
            DateTime Den_Ngay = dtpTuNgay.Value;
            string DenNgay = Den_Ngay.Date.ToString("yyyy/MM/dd");
            int count = 1;
            int TongDoanhThu = 0;
            foreach (DataRow row in BLL_SuatChieu.Instance.GetDoanhThuByTimePeriod(TenPhim, TuNgay, DenNgay).Rows)
            {
                ListViewItem lvi = new ListViewItem(count.ToString());
                lvi.SubItems.Add(row["MaPhim"].ToString());
                lvi.SubItems.Add(row["TenPhim"].ToString());
                lvi.SubItems.Add(row["MaGhe"].ToString());
                lvi.SubItems.Add(row["MaKhachHang"].ToString());
                lvi.SubItems.Add(row["NgayBanVe"].ToString());
                lvi.SubItems.Add(row["GiaVe"].ToString());
                lstDoangThuKhoangTime.Items.Add(lvi);
                count++;
                TongDoanhThu += int.Parse(row["GiaVe"].ToString());
            }
            txtTongDoanhThu.Text = TongDoanhThu+"";
        }

        private void DoanhThu_KhoangThoiGianControl_Load(object sender, EventArgs e)
        {
            foreach(DataRow row in BLL_Phim.Instance.GetAllPhim().Rows)
            {
                cbbTenPhim.Items.Add(row["TenPhim"].ToString());
            }
        }
    }
}
