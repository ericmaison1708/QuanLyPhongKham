namespace QuanLyPhongKham
{
    partial class FrmPhieuKetQua
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
            this.lsvPKB = new System.Windows.Forms.ListView();
            this.colMaKetQua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaPhieuKB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenBS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTienSu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMui = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChanDoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNoiDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKetLuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gbThongTinBN = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbtenbs = new System.Windows.Forms.ComboBox();
            this.cbbMaPKb = new System.Windows.Forms.ComboBox();
            this.cbbMaBN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbThongTinBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvPKB
            // 
            this.lsvPKB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaKetQua,
            this.colMaPhieuKB,
            this.colTenBS,
            this.colTenBN,
            this.colTienSu,
            this.colTai,
            this.colMui,
            this.colHong,
            this.colChanDoan,
            this.colNoiDung,
            this.colKetLuan});
            this.lsvPKB.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPKB.FullRowSelect = true;
            this.lsvPKB.GridLines = true;
            this.lsvPKB.HideSelection = false;
            this.lsvPKB.Location = new System.Drawing.Point(16, 404);
            this.lsvPKB.Margin = new System.Windows.Forms.Padding(2);
            this.lsvPKB.Name = "lsvPKB";
            this.lsvPKB.Size = new System.Drawing.Size(919, 246);
            this.lsvPKB.TabIndex = 98;
            this.lsvPKB.UseCompatibleStateImageBehavior = false;
            this.lsvPKB.View = System.Windows.Forms.View.Details;
            // 
            // colMaKetQua
            // 
            this.colMaKetQua.Text = "Mã kết quả";
            this.colMaKetQua.Width = 113;
            // 
            // colMaPhieuKB
            // 
            this.colMaPhieuKB.Text = "Mã Phiếu KB";
            this.colMaPhieuKB.Width = 124;
            // 
            // colTenBS
            // 
            this.colTenBS.Text = "Tên bác sỹ";
            this.colTenBS.Width = 123;
            // 
            // colTenBN
            // 
            this.colTenBN.Text = "Tên bệnh nhân";
            this.colTenBN.Width = 141;
            // 
            // colTienSu
            // 
            this.colTienSu.Text = "Tiền sử";
            this.colTienSu.Width = 132;
            // 
            // colTai
            // 
            this.colTai.Text = "Tai";
            this.colTai.Width = 89;
            // 
            // colMui
            // 
            this.colMui.Text = "Mũi";
            this.colMui.Width = 100;
            // 
            // colHong
            // 
            this.colHong.Text = "Họng";
            this.colHong.Width = 110;
            // 
            // colChanDoan
            // 
            this.colChanDoan.Text = "Chẩn đoán";
            this.colChanDoan.Width = 150;
            // 
            // colNoiDung
            // 
            this.colNoiDung.Text = "Nội dung";
            this.colNoiDung.Width = 150;
            // 
            // colKetLuan
            // 
            this.colKetLuan.Text = "Kết luận";
            this.colKetLuan.Width = 150;
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(721, 654);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(85, 52);
            this.bttThoat.TabIndex = 97;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            // 
            // bttHuy
            // 
            this.bttHuy.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.Location = new System.Drawing.Point(359, 654);
            this.bttHuy.Margin = new System.Windows.Forms.Padding(2);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(85, 52);
            this.bttHuy.TabIndex = 96;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            // 
            // bttLuu
            // 
            this.bttLuu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.Location = new System.Drawing.Point(272, 654);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(85, 52);
            this.bttLuu.TabIndex = 95;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = true;
            // 
            // bttSua
            // 
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.Location = new System.Drawing.Point(184, 654);
            this.bttSua.Margin = new System.Windows.Forms.Padding(2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(85, 52);
            this.bttSua.TabIndex = 94;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            // 
            // bttXoa
            // 
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.Location = new System.Drawing.Point(102, 654);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(80, 52);
            this.bttXoa.TabIndex = 93;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            // 
            // bttThem
            // 
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.Location = new System.Drawing.Point(28, 654);
            this.bttThem.Margin = new System.Windows.Forms.Padding(2);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(72, 52);
            this.bttThem.TabIndex = 92;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 36);
            this.label8.TabIndex = 91;
            this.label8.Text = "PHIẾU KẾT QUẢ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbThongTinBN
            // 
            this.gbThongTinBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbThongTinBN.Controls.Add(this.textBox6);
            this.gbThongTinBN.Controls.Add(this.label12);
            this.gbThongTinBN.Controls.Add(this.textBox5);
            this.gbThongTinBN.Controls.Add(this.label11);
            this.gbThongTinBN.Controls.Add(this.textBox4);
            this.gbThongTinBN.Controls.Add(this.label6);
            this.gbThongTinBN.Controls.Add(this.textBox3);
            this.gbThongTinBN.Controls.Add(this.label10);
            this.gbThongTinBN.Controls.Add(this.textBox2);
            this.gbThongTinBN.Controls.Add(this.label7);
            this.gbThongTinBN.Controls.Add(this.textBox1);
            this.gbThongTinBN.Controls.Add(this.label5);
            this.gbThongTinBN.Controls.Add(this.label4);
            this.gbThongTinBN.Controls.Add(this.cbbtenbs);
            this.gbThongTinBN.Controls.Add(this.cbbMaPKb);
            this.gbThongTinBN.Controls.Add(this.cbbMaBN);
            this.gbThongTinBN.Controls.Add(this.label1);
            this.gbThongTinBN.Controls.Add(this.txtDiaChi);
            this.gbThongTinBN.Controls.Add(this.label9);
            this.gbThongTinBN.Controls.Add(this.txtMaNV);
            this.gbThongTinBN.Controls.Add(this.label3);
            this.gbThongTinBN.Controls.Add(this.label2);
            this.gbThongTinBN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinBN.Location = new System.Drawing.Point(16, 65);
            this.gbThongTinBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbThongTinBN.Name = "gbThongTinBN";
            this.gbThongTinBN.Size = new System.Drawing.Size(919, 322);
            this.gbThongTinBN.TabIndex = 90;
            this.gbThongTinBN.TabStop = false;
            this.gbThongTinBN.Text = "Thông tin bệnh nhân";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(525, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(219, 28);
            this.textBox6.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(442, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "Họng:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(525, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(219, 28);
            this.textBox5.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(453, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "Mũi:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(525, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 28);
            this.textBox4.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tai:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(134, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(610, 28);
            this.textBox3.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Kết luận:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(134, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(610, 28);
            this.textBox2.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nội dung:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(134, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 28);
            this.textBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Chẩn đoán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên BS:";
            // 
            // cbbtenbs
            // 
            this.cbbtenbs.FormattingEnabled = true;
            this.cbbtenbs.Location = new System.Drawing.Point(134, 121);
            this.cbbtenbs.Margin = new System.Windows.Forms.Padding(2);
            this.cbbtenbs.Name = "cbbtenbs";
            this.cbbtenbs.Size = new System.Drawing.Size(219, 29);
            this.cbbtenbs.TabIndex = 21;
            // 
            // cbbMaPKb
            // 
            this.cbbMaPKb.FormattingEnabled = true;
            this.cbbMaPKb.Location = new System.Drawing.Point(134, 81);
            this.cbbMaPKb.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaPKb.Name = "cbbMaPKb";
            this.cbbMaPKb.Size = new System.Drawing.Size(219, 29);
            this.cbbMaPKb.TabIndex = 20;
            // 
            // cbbMaBN
            // 
            this.cbbMaBN.FormattingEnabled = true;
            this.cbbMaBN.Location = new System.Drawing.Point(525, 40);
            this.cbbMaBN.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaBN.Name = "cbbMaBN";
            this.cbbMaBN.Size = new System.Drawing.Size(219, 29);
            this.cbbMaBN.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên bệnh nhân:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(134, 164);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(219, 28);
            this.txtDiaChi.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tiền sử:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(134, 43);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(219, 28);
            this.txtMaNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Phiếu KB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã kết quả";
            // 
            // FrmPhieuKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 732);
            this.Controls.Add(this.lsvPKB);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbThongTinBN);
            this.Name = "FrmPhieuKetQua";
            this.Text = "FrmPhieuKetQua";
            this.gbThongTinBN.ResumeLayout(false);
            this.gbThongTinBN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvPKB;
        private System.Windows.Forms.ColumnHeader colMaKetQua;
        private System.Windows.Forms.ColumnHeader colMaPhieuKB;
        private System.Windows.Forms.ColumnHeader colTenBS;
        private System.Windows.Forms.ColumnHeader colTenBN;
        private System.Windows.Forms.ColumnHeader colTienSu;
        private System.Windows.Forms.ColumnHeader colTai;
        private System.Windows.Forms.ColumnHeader colMui;
        private System.Windows.Forms.ColumnHeader colHong;
        private System.Windows.Forms.ColumnHeader colChanDoan;
        private System.Windows.Forms.ColumnHeader colNoiDung;
        private System.Windows.Forms.ColumnHeader colKetLuan;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbThongTinBN;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbtenbs;
        private System.Windows.Forms.ComboBox cbbMaPKb;
        private System.Windows.Forms.ComboBox cbbMaBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}