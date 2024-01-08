using DevExpress.XtraEditors;
using Quanlyphongkham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QuanLyPhongKham
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        ConnectToSQL con = new ConnectToSQL();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = con.GetData("SELECT * FROM TaiKhoan where TenDangNhap = '" + txtTaiKhoan.Text + "' and MatKhau ='" + txtMatKhau.Text + "'");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain f = new FrmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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