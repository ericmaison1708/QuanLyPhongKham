namespace QuanLyPhongKham
{
    partial class FrmCTHoaDon
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
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.lsvCT = new System.Windows.Forms.ListView();
            this.colMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPKQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbThongTinBS = new System.Windows.Forms.GroupBox();
            this.cbbMaDon = new System.Windows.Forms.ComboBox();
            this.cbbMaHD = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinBS.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(338, 497);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(4);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(102, 50);
            this.bttLuu.TabIndex = 51;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(229, 497);
            this.bttSua.Margin = new System.Windows.Forms.Padding(4);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(102, 50);
            this.bttSua.TabIndex = 50;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(120, 497);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(4);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(102, 50);
            this.bttXoa.TabIndex = 49;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(10, 497);
            this.bttThem.Margin = new System.Windows.Forms.Padding(4);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(102, 50);
            this.bttThem.TabIndex = 48;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(914, 497);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(4);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(119, 50);
            this.bttThoat.TabIndex = 53;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(447, 497);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(4);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(102, 50);
            this.bttHuy.TabIndex = 52;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            // 
            // lsvCT
            // 
            this.lsvCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHD,
            this.colMaDon,
            this.colMaPKQ});
            this.lsvCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCT.FullRowSelect = true;
            this.lsvCT.GridLines = true;
            this.lsvCT.HideSelection = false;
            this.lsvCT.Location = new System.Drawing.Point(13, 234);
            this.lsvCT.Margin = new System.Windows.Forms.Padding(4);
            this.lsvCT.MultiSelect = false;
            this.lsvCT.Name = "lsvCT";
            this.lsvCT.Size = new System.Drawing.Size(1020, 243);
            this.lsvCT.TabIndex = 47;
            this.lsvCT.TabStop = false;
            this.lsvCT.UseCompatibleStateImageBehavior = false;
            this.lsvCT.View = System.Windows.Forms.View.Details;
            // 
            // colMaHD
            // 
            this.colMaHD.Text = "Mã hóa đơn";
            this.colMaHD.Width = 200;
            // 
            // colMaDon
            // 
            this.colMaDon.Text = "Mã đơn thuốc";
            this.colMaDon.Width = 250;
            // 
            // colMaPKQ
            // 
            this.colMaPKQ.Text = "Mã Phiếu kết quả";
            this.colMaPKQ.Width = 200;
            // 
            // gbThongTinBS
            // 
            this.gbThongTinBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbThongTinBS.Controls.Add(this.cbbMaDon);
            this.gbThongTinBS.Controls.Add(this.cbbMaHD);
            this.gbThongTinBS.Controls.Add(this.txtSoLuong);
            this.gbThongTinBS.Controls.Add(this.label5);
            this.gbThongTinBS.Controls.Add(this.label4);
            this.gbThongTinBS.Controls.Add(this.label2);
            this.gbThongTinBS.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinBS.Location = new System.Drawing.Point(13, 63);
            this.gbThongTinBS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbThongTinBS.Name = "gbThongTinBS";
            this.gbThongTinBS.Size = new System.Drawing.Size(1038, 149);
            this.gbThongTinBS.TabIndex = 46;
            this.gbThongTinBS.TabStop = false;
            // 
            // cbbMaDon
            // 
            this.cbbMaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaDon.FormattingEnabled = true;
            this.cbbMaDon.Location = new System.Drawing.Point(174, 82);
            this.cbbMaDon.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaDon.Name = "cbbMaDon";
            this.cbbMaDon.Size = new System.Drawing.Size(334, 32);
            this.cbbMaDon.TabIndex = 18;
            // 
            // cbbMaHD
            // 
            this.cbbMaHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHD.FormattingEnabled = true;
            this.cbbMaHD.Location = new System.Drawing.Point(174, 36);
            this.cbbMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaHD.Name = "cbbMaHD";
            this.cbbMaHD.Size = new System.Drawing.Size(334, 32);
            this.cbbMaHD.TabIndex = 17;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(680, 43);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(340, 28);
            this.txtSoLuong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã phiếu kết quả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã đơn thuốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 36);
            this.label1.TabIndex = 45;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCTHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 558);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.lsvCT);
            this.Controls.Add(this.gbThongTinBS);
            this.Controls.Add(this.label1);
            this.Name = "FrmCTHoaDon";
            this.Text = "FrmCTHoaDon";
            this.gbThongTinBS.ResumeLayout(false);
            this.gbThongTinBS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.ListView lsvCT;
        private System.Windows.Forms.ColumnHeader colMaHD;
        private System.Windows.Forms.ColumnHeader colMaDon;
        private System.Windows.Forms.ColumnHeader colMaPKQ;
        private System.Windows.Forms.GroupBox gbThongTinBS;
        private System.Windows.Forms.ComboBox cbbMaDon;
        private System.Windows.Forms.ComboBox cbbMaHD;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}