namespace QuanLyPhongKham
{
    partial class FrmPhongCho
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcTTPhongCho = new DevExpress.XtraEditors.GroupControl();
            this.cbbTenPK = new System.Windows.Forms.ComboBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.radbttTatCa = new System.Windows.Forms.RadioButton();
            this.radbttDaKham = new System.Windows.Forms.RadioButton();
            this.radbttChuaKham = new System.Windows.Forms.RadioButton();
            this.lsvCT = new System.Windows.Forms.ListView();
            this.colMaPhieuKB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiKham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbT = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bttXem = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcTTPhongCho)).BeginInit();
            this.gcTTPhongCho.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(179, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(513, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "PHÒNG CHỜ KHÁM BỆNH";
            // 
            // gcTTPhongCho
            // 
            this.gcTTPhongCho.Appearance.BackColor = System.Drawing.Color.White;
            this.gcTTPhongCho.Appearance.Options.UseBackColor = true;
            this.gcTTPhongCho.Controls.Add(this.cbbTenPK);
            this.gcTTPhongCho.Controls.Add(this.dtNgayLap);
            this.gcTTPhongCho.Controls.Add(this.radbttTatCa);
            this.gcTTPhongCho.Controls.Add(this.radbttDaKham);
            this.gcTTPhongCho.Controls.Add(this.radbttChuaKham);
            this.gcTTPhongCho.Location = new System.Drawing.Point(12, 92);
            this.gcTTPhongCho.Name = "gcTTPhongCho";
            this.gcTTPhongCho.Size = new System.Drawing.Size(823, 157);
            this.gcTTPhongCho.TabIndex = 1;
            // 
            // cbbTenPK
            // 
            this.cbbTenPK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenPK.FormattingEnabled = true;
            this.cbbTenPK.Location = new System.Drawing.Point(327, 72);
            this.cbbTenPK.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenPK.Name = "cbbTenPK";
            this.cbbTenPK.Size = new System.Drawing.Size(289, 32);
            this.cbbTenPK.TabIndex = 9;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "dd-MM-yyyy ";
            this.dtNgayLap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(327, 32);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(353, 32);
            this.dtNgayLap.TabIndex = 8;
            // 
            // radbttTatCa
            // 
            this.radbttTatCa.AutoSize = true;
            this.radbttTatCa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttTatCa.Location = new System.Drawing.Point(70, 108);
            this.radbttTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.radbttTatCa.Name = "radbttTatCa";
            this.radbttTatCa.Size = new System.Drawing.Size(87, 28);
            this.radbttTatCa.TabIndex = 7;
            this.radbttTatCa.TabStop = true;
            this.radbttTatCa.Text = "Tất cả";
            this.radbttTatCa.UseVisualStyleBackColor = true;
            // 
            // radbttDaKham
            // 
            this.radbttDaKham.AutoSize = true;
            this.radbttDaKham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttDaKham.Location = new System.Drawing.Point(70, 72);
            this.radbttDaKham.Margin = new System.Windows.Forms.Padding(4);
            this.radbttDaKham.Name = "radbttDaKham";
            this.radbttDaKham.Size = new System.Drawing.Size(111, 28);
            this.radbttDaKham.TabIndex = 6;
            this.radbttDaKham.TabStop = true;
            this.radbttDaKham.Text = "Đã khám";
            this.radbttDaKham.UseVisualStyleBackColor = true;
            // 
            // radbttChuaKham
            // 
            this.radbttChuaKham.AutoSize = true;
            this.radbttChuaKham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttChuaKham.Location = new System.Drawing.Point(70, 36);
            this.radbttChuaKham.Margin = new System.Windows.Forms.Padding(4);
            this.radbttChuaKham.Name = "radbttChuaKham";
            this.radbttChuaKham.Size = new System.Drawing.Size(132, 28);
            this.radbttChuaKham.TabIndex = 5;
            this.radbttChuaKham.TabStop = true;
            this.radbttChuaKham.Text = "Chưa khám";
            this.radbttChuaKham.UseVisualStyleBackColor = true;
            // 
            // lsvCT
            // 
            this.lsvCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieuKB,
            this.colHoTenBN,
            this.colLoaiKham,
            this.colTinhTrang});
            this.lsvCT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCT.FullRowSelect = true;
            this.lsvCT.GridLines = true;
            this.lsvCT.HideSelection = false;
            this.lsvCT.Location = new System.Drawing.Point(12, 256);
            this.lsvCT.Margin = new System.Windows.Forms.Padding(4);
            this.lsvCT.MultiSelect = false;
            this.lsvCT.Name = "lsvCT";
            this.lsvCT.Size = new System.Drawing.Size(823, 251);
            this.lsvCT.TabIndex = 2;
            this.lsvCT.TabStop = false;
            this.lsvCT.UseCompatibleStateImageBehavior = false;
            this.lsvCT.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhieuKB
            // 
            this.colMaPhieuKB.Text = "Mã phiếu khám bệnh";
            this.colMaPhieuKB.Width = 200;
            // 
            // colHoTenBN
            // 
            this.colHoTenBN.Text = "Họ tên bệnh nhân";
            this.colHoTenBN.Width = 200;
            // 
            // colLoaiKham
            // 
            this.colLoaiKham.Text = "Loại khám";
            this.colLoaiKham.Width = 200;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình Trạng khám";
            this.colTinhTrang.Width = 150;
            // 
            // lbT
            // 
            this.lbT.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbT.Appearance.Options.UseFont = true;
            this.lbT.Location = new System.Drawing.Point(443, 534);
            this.lbT.Margin = new System.Windows.Forms.Padding(4);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(118, 24);
            this.lbT.TabIndex = 12;
            this.lbT.Text = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(293, 534);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 24);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Tổng bệnh nhân:";
            // 
            // bttXem
            // 
            this.bttXem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXem.Location = new System.Drawing.Point(8, 521);
            this.bttXem.Margin = new System.Windows.Forms.Padding(4);
            this.bttXem.Name = "bttXem";
            this.bttXem.Size = new System.Drawing.Size(102, 50);
            this.bttXem.TabIndex = 9;
            this.bttXem.Text = "Xem";
            this.bttXem.UseVisualStyleBackColor = true;
            // 
            // bttThoat
            // 
            this.bttThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(733, 521);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(4);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(102, 50);
            this.bttThoat.TabIndex = 10;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            // 
            // FrmPhongCho
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 586);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.bttXem);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.lsvCT);
            this.Controls.Add(this.gcTTPhongCho);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmPhongCho";
            this.Text = "Phòng chờ";
            ((System.ComponentModel.ISupportInitialize)(this.gcTTPhongCho)).EndInit();
            this.gcTTPhongCho.ResumeLayout(false);
            this.gcTTPhongCho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl gcTTPhongCho;
        private System.Windows.Forms.ComboBox cbbTenPK;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.RadioButton radbttTatCa;
        private System.Windows.Forms.RadioButton radbttDaKham;
        private System.Windows.Forms.RadioButton radbttChuaKham;
        private System.Windows.Forms.ListView lsvCT;
        private System.Windows.Forms.ColumnHeader colMaPhieuKB;
        private System.Windows.Forms.ColumnHeader colHoTenBN;
        private System.Windows.Forms.ColumnHeader colLoaiKham;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private DevExpress.XtraEditors.LabelControl lbT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button bttXem;
        private System.Windows.Forms.Button bttThoat;
    }
}