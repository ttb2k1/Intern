using DoAn_ver5.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI.DanhMuc
{
    public partial class VeControl : UserControl
    {
        private static VeControl _instance;
        public static VeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VeControl();
                return _instance;
            }
        }
        public VeControl()
        {
            InitializeComponent();
        }

        

        
        private void btnTim_Click(object sender, EventArgs e)
        {
            string dt1 = dtpTuNgay.Value.ToString("yyyy/MM/dd");
            string dt2 = dtpDenNgay.Value.ToString("yyyy/MM/dd");
            string MaVe = txtMaVe.Text;
            string TenKH = txtMaKhachHang.Text;
            int count = 1;
            if(chkMaKhachHang.Checked == true)
            {
                listView1.Items.Clear();
                foreach(DataRow i in BLL_Ve.Instance.GetVeByTenKH(TenKH).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaHoaDonVe"].ToString());
                    ls.SubItems.Add(i["MaSuatChieu"].ToString());
                    ls.SubItems.Add(i["MaGhe"].ToString());
                    ls.SubItems.Add(i["NgayBanVe"].ToString());
                    ls.SubItems.Add(i["HovaTen"].ToString());
                    ls.SubItems.Add(i["GiaVe"].ToString());
                    ls.SubItems.Add(i["TenKhachHang"].ToString());
                    listView1.Items.Add(ls);
                    count++;
                }
            }
            if(chkMaVe.Checked == true)
            {
                listView1.Items.Clear();
                foreach(DataRow i in BLL_Ve.Instance.GetVeByMaVe(MaVe).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaHoaDonVe"].ToString());
                    ls.SubItems.Add(i["MaSuatChieu"].ToString());
                    ls.SubItems.Add(i["MaGhe"].ToString());
                    ls.SubItems.Add(i["NgayBanVe"].ToString());
                    ls.SubItems.Add(i["HovaTen"].ToString());
                    ls.SubItems.Add(i["GiaVe"].ToString());
                    ls.SubItems.Add(i["TenKhachHang"].ToString());
                    listView1.Items.Add(ls);
                    count++;
                }
            }
            if(chkThoiGian.Checked == true)
            {
                listView1.Items.Clear();
                foreach(DataRow i in BLL_Ve.Instance.GetVeByDate(dt1, dt2).Rows)
                {
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaHoaDonVe"].ToString());
                    ls.SubItems.Add(i["MaSuatChieu"].ToString());
                    ls.SubItems.Add(i["MaGhe"].ToString());
                    ls.SubItems.Add(i["NgayBanVe"].ToString());
                    ls.SubItems.Add(i["HovaTen"].ToString());
                    ls.SubItems.Add(i["GiaVe"].ToString());
                    ls.SubItems.Add(i["TenKhachHang"].ToString());
                    listView1.Items.Add(ls);
                    count++;
                }
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            int count = 1;
            listView1.Items.Clear();
            foreach(DataRow i in BLL_Ve.Instance.GetVe().Rows)
            {
                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(i["MaHoaDonVe"].ToString());
                ls.SubItems.Add(i["MaSuatChieu"].ToString());
                ls.SubItems.Add(i["MaGhe"].ToString());
                ls.SubItems.Add(i["NgayBanVe"].ToString());
                ls.SubItems.Add(i["HovaTen"].ToString());
                ls.SubItems.Add(i["GiaVe"].ToString());
                ls.SubItems.Add(i["TenKhachHang"].ToString());
                listView1.Items.Add (ls);
                count++;
            }
        }

        private void chkMaVe_CheckedChanged_1(object sender, EventArgs e)
        {
            if(chkMaVe.Checked == true)
            {
                txtMaVe.Enabled = true;
                chkMaKhachHang.Checked = false;
                txtMaKhachHang.Enabled = false;
                chkThoiGian.Checked = false;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void chkMaKhachHang_CheckedChanged_1(object sender, EventArgs e)
        {
            if(chkMaKhachHang.Checked == true)
            {
                txtMaKhachHang.Enabled = true;
                chkMaVe.Checked = false;
                txtMaVe.Enabled = false;
                chkThoiGian.Checked = false;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void chkThoiGian_CheckedChanged_1(object sender, EventArgs e)
        {
            if(chkThoiGian.Checked == true)
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
                chkMaVe.Checked = false;
                txtMaVe.Enabled = false;
                chkMaKhachHang.Checked = false;
                txtMaKhachHang.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            chkMaKhachHang.Checked = false;
            chkMaVe.Checked = false;
            chkThoiGian.Checked = false;
            txtMaKhachHang.Text = "";
            txtMaVe.Text = "";
        }
    }
}
