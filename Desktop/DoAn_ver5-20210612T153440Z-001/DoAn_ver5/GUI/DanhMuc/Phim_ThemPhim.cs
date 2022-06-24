using DoAn_ver5.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI
{
    public partial class Phim_ThemPhim : Form
    {
        public Phim_ThemPhim()
        {
            InitializeComponent();
            SetCBBTrangThai();
            SetGioiHanTuoi();
            
        }

        public void SetCBBTrangThai()
        {
            cbbTrangThai.Items.Add("Công Chiếu");
        }
        public void SetGioiHanTuoi()
        {
            for(int i = 12; i <= 60; i++)
            {
                cbbDotuoi.Items.Add(i + "");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAL_Phim.Instance.InsertPhim
            (
                txtMaPhim.Text.Trim(),
                txtTenPhim.Text.Trim(),
                int.Parse(numericUpDown2.Value.ToString()),
                int.Parse(numericUpDown3.Value.ToString()),
                int.Parse(cbbDotuoi.SelectedItem.ToString()),
                dtpNgayChieu.Value.Date.ToString("yyyy/MM/dd"),
                cbbTrangThai.SelectedItem.ToString(),
                txtDienVien.Text.Trim(),
                cbbNuocsx.SelectedItem.ToString(),
                cbbNN.SelectedItem.ToString(),
                cbbNhasx.SelectedItem.ToString(),
                int.Parse(txtDoanhThu.Text.Trim()),
                txtTomTat.Text.Trim()
            );
            this.Close();
        }
    }
}
