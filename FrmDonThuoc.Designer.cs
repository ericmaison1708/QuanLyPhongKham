namespace QuanLyPhongKham
{
    partial class FrmDonThuoc
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
            this.gbThongTinBS = new System.Windows.Forms.GroupBox();
            this.cbbMaPhieuKQ = new System.Windows.Forms.ComboBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bttXem = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.lsvDonThuoc = new System.Windows.Forms.ListView();
            this.colMaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPhieuKQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayLap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbThongTinBS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTinBS
            // 
            this.gbThongTinBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbThongTinBS.Controls.Add(this.cbbMaPhieuKQ);
            this.gbThongTinBS.Controls.Add(this.dtNgayLap);
            this.gbThongTinBS.Controls.Add(this.txtTongTien);
            this.gbThongTinBS.Controls.Add(this.txtMaDon);
            this.gbThongTinBS.Controls.Add(this.label5);
            this.gbThongTinBS.Controls.Add(this.label4);
            this.gbThongTinBS.Controls.Add(this.label3);
            this.gbThongTinBS.Controls.Add(this.label2);
            this.gbThongTinBS.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinBS.Location = new System.Drawing.Point(21, 58);
            this.gbThongTinBS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbThongTinBS.Name = "gbThongTinBS";
            this.gbThongTinBS.Size = new System.Drawing.Size(1027, 176);
            this.gbThongTinBS.TabIndex = 34;
            this.gbThongTinBS.TabStop = false;
            // 
            // cbbMaPhieuKQ
            // 
            this.cbbMaPhieuKQ.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaPhieuKQ.FormattingEnabled = true;
            this.cbbMaPhieuKQ.Location = new System.Drawing.Point(632, 31);
            this.cbbMaPhieuKQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMaPhieuKQ.Name = "cbbMaPhieuKQ";
            this.cbbMaPhieuKQ.Size = new System.Drawing.Size(376, 32);
            this.cbbMaPhieuKQ.TabIndex = 11;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CalendarFont = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(124, 85);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtNgayLap.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtNgayLap.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(304, 28);
            this.dtNgayLap.TabIndex = 3;
            this.dtNgayLap.Value = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(124, 131);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(235, 28);
            this.txtTongTien.TabIndex = 8;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDon.Location = new System.Drawing.Point(124, 43);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(304, 28);
            this.txtMaDon.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập:";
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
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "ĐƠN THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(626, 521);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 63);
            this.button1.TabIndex = 32;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bttXem
            // 
            this.bttXem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXem.Location = new System.Drawing.Point(512, 521);
            this.bttXem.Margin = new System.Windows.Forms.Padding(4);
            this.bttXem.Name = "bttXem";
            this.bttXem.Size = new System.Drawing.Size(91, 63);
            this.bttXem.TabIndex = 30;
            this.bttXem.Text = "Xem CT";
            this.bttXem.UseVisualStyleBackColor = true;
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(958, 521);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(4);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(91, 63);
            this.bttThoat.TabIndex = 31;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(414, 521);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(4);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(91, 63);
            this.bttHuy.TabIndex = 29;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(316, 521);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(4);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(91, 63);
            this.bttLuu.TabIndex = 28;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(218, 521);
            this.bttSua.Margin = new System.Windows.Forms.Padding(4);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(91, 63);
            this.bttSua.TabIndex = 27;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(120, 521);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(4);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(91, 63);
            this.bttXoa.TabIndex = 26;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(22, 521);
            this.bttThem.Margin = new System.Windows.Forms.Padding(4);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(91, 63);
            this.bttThem.TabIndex = 25;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            // 
            // lsvDonThuoc
            // 
            this.lsvDonThuoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaDon,
            this.colMaPhieuKQ,
            this.colNgayLap,
            this.colTongTien});
            this.lsvDonThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDonThuoc.FullRowSelect = true;
            this.lsvDonThuoc.GridLines = true;
            this.lsvDonThuoc.HideSelection = false;
            this.lsvDonThuoc.Location = new System.Drawing.Point(21, 247);
            this.lsvDonThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDonThuoc.MultiSelect = false;
            this.lsvDonThuoc.Name = "lsvDonThuoc";
            this.lsvDonThuoc.Size = new System.Drawing.Size(1027, 266);
            this.lsvDonThuoc.TabIndex = 24;
            this.lsvDonThuoc.TabStop = false;
            this.lsvDonThuoc.UseCompatibleStateImageBehavior = false;
            this.lsvDonThuoc.View = System.Windows.Forms.View.Details;
            // 
            // colMaDon
            // 
            this.colMaDon.Text = "Mã đơn thuốc";
            this.colMaDon.Width = 150;
            // 
            // colMaPhieuKQ
            // 
            this.colMaPhieuKQ.Text = "Mã phiếu kết quả";
            this.colMaPhieuKQ.Width = 187;
            // 
            // colNgayLap
            // 
            this.colNgayLap.Text = "Ngày lập";
            this.colNgayLap.Width = 179;
            // 
            // colTongTien
            // 
            this.colTongTien.Text = "Tổng tiền";
            this.colTongTien.Width = 150;
            // 
            // FrmDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 607);
            this.Controls.Add(this.gbThongTinBS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttXem);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.lsvDonThuoc);
            this.Name = "FrmDonThuoc";
            this.Text = "Đơn thuốc";
            this.gbThongTinBS.ResumeLayout(false);
            this.gbThongTinBS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinBS;
        private System.Windows.Forms.ComboBox cbbMaPhieuKQ;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttXem;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.ListView lsvDonThuoc;
        private System.Windows.Forms.ColumnHeader colMaDon;
        private System.Windows.Forms.ColumnHeader colMaPhieuKQ;
        private System.Windows.Forms.ColumnHeader colNgayLap;
        private System.Windows.Forms.ColumnHeader colTongTien;
    }
}