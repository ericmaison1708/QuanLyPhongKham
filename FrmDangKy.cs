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
    public partial class FrmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textEdit3.Text == textEdit2.Text)
            {
                if (textEdit2.Text.Length >= 6 && textEdit2.Text.Length <= 18)
                {
                    FrmDangNhap f = new FrmDangNhap();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    errorProvider1.SetError(textEdit2, "Độ dài mật khẩu phải từ 6 - 18 kí tự !");
                }
            }
            else
            {
                errorProvider1.SetError(textEdit3, "Mật khẩu chưa trùng khớp, vui lòng thử lại !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                FrmDangNhap f = new FrmDangNhap();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}