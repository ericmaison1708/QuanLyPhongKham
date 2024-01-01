using DevExpress.Utils.Serializing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm

        
    {

        public string TenDangNhap { get; set; } = "";
        public string MatKhau { get; set; } = "";
        public string Quyen { get; set; } = "";

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(string TenDangNhap, string MatKhau, string Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bbtiChaoMung.Caption = "Quyền: " + Quyen;
            rpgHeThong.Text = "Xin chào: " + TenDangNhap;
        }
        public void showLoadingForm()
        {
            SplashScreenManager.ShowForm(this, typeof(FrmLoading), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("PHÒNG KHÁM ERIC...");
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(1);
            }
            SplashScreenManager.CloseForm();
        }
        private void bbtiDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bbtiDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                showLoadingForm();
                FrmDangNhap f = new FrmDangNhap();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void bbtiDSTK_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void bbtiBacSi_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmBacSi());
        }

        private void bbitBenhNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmBenhNhan());
        }

        private void bbtiThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmDanhMucThuoc());
        }

        private void bbtiNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmNhanVien());
        }

        private void bbtiNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmNhaCungCap());
        }

        private void bbtiThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                showLoadingForm();
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void bbtiPhieuKhamBenh_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmPhieuKhamBenh());
        }

        private void bbtiPhieuKetQua_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmPhieuKetQua());
        }

        private void bbtiDonThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmDonThuoc());
        }

        private void bbtiHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmHoaDon());
        }

        private void bbtiLoaiThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmLoaiThuoc());
        }

        private void bbtiDSPhongCho_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmPhongCho());
        }

        private void bbtiDichVuKham_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmDichVuKham());
        }

        private void bbtiPhieuNhapThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmPhieuNhapThuoc());
        }

        private void bbtiCTPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoadingForm();
            OpenChildForm(new FrmCTPhieuNhap());
        }
    }
}