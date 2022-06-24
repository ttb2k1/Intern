using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_ver5.BLL;

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class DoanhThu_KhachHangControl : UserControl
    {
        private static DoanhThu_KhachHangControl _instance;
        public static DoanhThu_KhachHangControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DoanhThu_KhachHangControl();
                return _instance;
            }
        }
        public DoanhThu_KhachHangControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVIP.Checked == true) chkThuong.Checked = false;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (chkVIP.Checked == true)
            {
                int count = 1;
                foreach(DataRow row in BLL.BLL_KhachHang.Instance.GetlistDoanhThuKH().Rows)
                {
                    if (row["LoaiKhachHang"].ToString() == "VIP")
                    {
                        ListViewItem lvi = new ListViewItem(count + "");
                        lvi.SubItems.Add(row["MaKhachHang"].ToString());
                        lvi.SubItems.Add(row["TenKhachHang"].ToString());
                        lvi.SubItems.Add(row["NgayDangKy"].ToString());
                        lvi.SubItems.Add(row["LoaiKhachHang"].ToString());
                        lvi.SubItems.Add(row["DoanhThu"].ToString());
                        lstDoanhThuKH.Items.Add(lvi);
                        lvi.Tag = row["LoaiKhachHang"].ToString();
                        count++;
                    }
                }
            }
            if (chkVIP.Checked == false)
            {
                foreach (ListViewItem lvi in lstDoanhThuKH.Items)
                {
                    if ((string)lvi.Tag == "VIP")
                    {
                        lstDoanhThuKH.Items.Remove(lvi);
                    }

                }
            }
        }

        private void chkThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThuong.Checked == true) chkVIP.Checked = false;
        }
    }
}
