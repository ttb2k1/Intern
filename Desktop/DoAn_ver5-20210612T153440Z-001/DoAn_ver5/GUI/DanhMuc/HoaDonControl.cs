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
    public partial class HoaDonControl : UserControl
    {
        private static HoaDonControl _instance;
        public static HoaDonControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonControl();
                return _instance;
            }
        }
        public HoaDonControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkMa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMa.Checked == true)
            {
                txtMa.Enabled = true;
                chkThoiGian.Checked = false;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void chkThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if(chkThoiGian.Checked == true)
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
                chkMa.Checked = false;
                txtMa.Enabled = false;
            }
        }
        
        public int TongTien(int sum = 0)
        {            
            ListViewItem ls = new ListViewItem();
            foreach(DataRow i in BLL_HoaDon.Instance.GetThucAnByMaHD(ls.SubItems[1].Text).Rows)
            {
                int KichCo = int.Parse(listView2.SelectedItems[0].SubItems[3].Text);
                int GiaBan = int.Parse(listView2.SelectedItems[0].SubItems[4].Text);
                sum += KichCo * GiaBan;
                return sum;
            }
            return sum;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            int count = 1;
            string Ma = txtMa.Text;
            string dt1 = dtpTuNgay.Value.ToString("yyyy/MM/dd");
            string dt2 = dtpDenNgay.Value.ToString("yyyy/MM/dd");
            if(chkMa.Checked == true)
            {
                listView1.Items.Clear();
                
                foreach (DataRow i in BLL_HoaDon.Instance.GetHoaDonByMaHD(Ma).Rows)
                {                    
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaHoaDon"].ToString());
                    ls.SubItems.Add(i["NgayTao"].ToString());
                    ls.SubItems.Add(BLL_HoaDon.Instance.GetTongTienByMHD(i["MaHoaDon"].ToString()) + "");
                    ls.SubItems.Add(i["MaNhanVien"].ToString());
                    listView1.Items.Add(ls);
                    count++;
                }
            }
            if(chkThoiGian.Checked == true)
            {
                listView1.Items.Clear();
                foreach(DataRow i in BLL_HoaDon.Instance.GetHoaDonByDate(dt1, dt2).Rows)
                {
                                    
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(i["MaHoaDon"].ToString());
                    ls.SubItems.Add(i["NgayTao"].ToString());
                    ls.SubItems.Add(BLL_HoaDon.Instance.GetTongTienByMHD(i["MaHoaDon"].ToString()) + "");
                    ls.SubItems.Add(i["MaNhanVien"].ToString());
                    listView1.Items.Add(ls);
                    count++;
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkMa.Checked = false;
            chkThoiGian.Checked = false;
            dtpTuNgay.Enabled = false;
            dtpDenNgay.Enabled = false;
            txtMa.Text = "";
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            int count = 1;
            listView1.Items.Clear();
            
            foreach(DataRow i in BLL_HoaDon.Instance.GetHoaDon().Rows)
            {
                
                
                ListViewItem ls = new ListViewItem(count.ToString());
                ls.SubItems.Add(i["MaHoaDon"].ToString());
                ls.SubItems.Add(i["NgayTao"].ToString());
                ls.SubItems.Add(BLL_HoaDon.Instance.GetTongTienByMHD(i["MaHoaDon"].ToString()) + "");
                ls.SubItems.Add(i["MaNhanVien"].ToString());
                listView1.Items.Add(ls);
                count++;
            }

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem ls = listView1.SelectedItems[0];
            int count = 1;
            listView2.Items.Clear();
            foreach(DataRow i in BLL_HoaDon.Instance.GetThucAnByMaHD(ls.SubItems[1].Text).Rows)
            {
                ListViewItem sl = new ListViewItem(count.ToString());
                sl.SubItems.Add(i["MaThucAn"].ToString());
                sl.SubItems.Add(i["TenThucAn"].ToString());
                sl.SubItems.Add(i["KichCo"].ToString());
                sl.SubItems.Add(i["GiaBan"].ToString());
                sl.SubItems.Add(i["SoLuong"].ToString());
                listView2.Items.Add(sl);
                count++;
            }
        }
    }
}
