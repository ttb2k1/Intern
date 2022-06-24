using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI.HeThong
{
    public partial class TaiKhoanControl : UserControl
    {
        private static TaiKhoanControl _instance;
        public static TaiKhoanControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaiKhoanControl();
                return _instance;
            }
        }
        public TaiKhoanControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
