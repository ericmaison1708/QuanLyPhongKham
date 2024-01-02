using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            FrmDangKy f = new FrmDangKy();  
            this.Hide(); f.ShowDialog();
        }
    }
}