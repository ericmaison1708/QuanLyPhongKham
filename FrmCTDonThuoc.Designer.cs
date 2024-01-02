namespace QuanLyPhongKham
{
    partial class FrmCTDonThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvCT = new System.Windows.Forms.ListView();
            this.colMaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPhieuKQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.gbThongTinBS = new System.Windows.Forms.GroupBox();
            this.cbbTenThuoc = new System.Windows.Forms.ComboBox();
            this.cbbMaDon = new System.Windows.Forms.ComboBox();
            this.txtMaPhieuKQ = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinBS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvCT
            // 
            this.lsvCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaDon,
            this.colMaPhieuKQ,
            this.colTenThuoc,
            this.colSoLuong});
            this.lsvCT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCT.FullRowSelect = true;
            this.lsvCT.GridLines = true;
            this.lsvCT.HideSelection = false;
            this.lsvCT.Location = new System.Drawing.Point(17, 239);
            this.lsvCT.Margin = new System.Windows.Forms.Padding(4);
            this.lsvCT.MultiSelect = false;
            this.lsvCT.Name = "lsvCT";
            this.lsvCT.Size = new System.Drawing.Size(1024, 269);
            this.lsvCT.TabIndex = 50;
            this.lsvCT.TabStop = false;
            this.lsvCT.UseCompatibleStateImageBehavior = false;
            this.lsvCT.View = System.Windows.Forms.View.Details;
            // 
            // colMaDon
            // 
            this.colMaDon.Text = "Mã đơn thuốc";
            this.colMaDon.Width = 150;
            // 
            // colMaPhieuKQ
            // 
            this.colMaPhieuKQ.Text = "Mã phiếu kết quả";
            this.colMaPhieuKQ.Width = 196;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.Text = "Tên thuốc";
            this.colTenThuoc.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 100;
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(950, 516);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(4);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(91, 63);
            this.bttThoat.TabIndex = 49;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(409, 516);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(4);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(91, 63);
            this.bttHuy.TabIndex = 48;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(311, 516);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(4);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(91, 63);
            this.bttLuu.TabIndex = 47;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(213, 516);
            this.bttSua.Margin = new System.Windows.Forms.Padding(4);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(91, 63);
            this.bttSua.TabIndex = 46;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(115, 516);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(4);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(91, 63);
            this.bttXoa.TabIndex = 45;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(17, 516);
            this.bttThem.Margin = new System.Windows.Forms.Padding(4);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(91, 63);
            this.bttThem.TabIndex = 44;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            // 
            // gbThongTinBS
            // 
            this.gbThongTinBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbThongTinBS.Controls.Add(this.cbbTenThuoc);
            this.gbThongTinBS.Controls.Add(this.cbbMaDon);
            this.gbThongTinBS.Controls.Add(this.txtMaPhieuKQ);
            this.gbThongTinBS.Controls.Add(this.txtTongTien);
            this.gbThongTinBS.Controls.Add(this.label5);
            this.gbThongTinBS.Controls.Add(this.label4);
            this.gbThongTinBS.Controls.Add(this.label3);
            this.gbThongTinBS.Controls.Add(this.label2);
            this.gbThongTinBS.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinBS.Location = new System.Drawing.Point(18, 47);
            this.gbThongTinBS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbThongTinBS.Name = "gbThongTinBS";
            this.gbThongTinBS.Size = new System.Drawing.Size(1027, 176);
            this.gbThongTinBS.TabIndex = 43;
            this.gbThongTinBS.TabStop = false;
            // 
            // cbbTenThuoc
            // 
            this.cbbTenThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenThuoc.FormattingEnabled = true;
            this.cbbTenThuoc.Location = new System.Drawing.Point(153, 85);
            this.cbbTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenThuoc.Name = "cbbTenThuoc";
            this.cbbTenThuoc.Size = new System.Drawing.Size(304, 32);
            this.cbbTenThuoc.TabIndex = 11;
            // 
            // cbbMaDon
            // 
            this.cbbMaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaDon.FormattingEnabled = true;
            this.cbbMaDon.Location = new System.Drawing.Point(153, 35);
            this.cbbMaDon.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaDon.Name = "cbbMaDon";
            this.cbbMaDon.Size = new System.Drawing.Size(304, 32);
            this.cbbMaDon.TabIndex = 10;
            // 
            // txtMaPhieuKQ
            // 
            this.txtMaPhieuKQ.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuKQ.Location = new System.Drawing.Point(633, 35);
            this.txtMaPhieuKQ.Name = "txtMaPhieuKQ";
            this.txtMaPhieuKQ.Size = new System.Drawing.Size(304, 28);
            this.txtMaPhieuKQ.TabIndex = 9;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(153, 131);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(235, 28);
            this.txtTongTien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phiếu kết quả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "CHI TIẾT ĐƠN THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCTDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 597);
            this.Controls.Add(this.lsvCT);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.gbThongTinBS);
            this.Controls.Add(this.label1);
            this.Name = "FrmCTDonThuoc";
            this.Text = "FrmCTDonThuoc";
            this.gbThongTinBS.ResumeLayout(false);
            this.gbThongTinBS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvCT;
        private System.Windows.Forms.ColumnHeader colMaDon;
        private System.Windows.Forms.ColumnHeader colMaPhieuKQ;
        private System.Windows.Forms.ColumnHeader colTenThuoc;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.GroupBox gbThongTinBS;
        private System.Windows.Forms.ComboBox cbbTenThuoc;
        private System.Windows.Forms.ComboBox cbbMaDon;
        private System.Windows.Forms.TextBox txtMaPhieuKQ;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}