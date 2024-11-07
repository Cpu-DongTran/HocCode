namespace HocCoder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtMailNhan = new TextBox();
            TxtTieuDe = new TextBox();
            TxtNoiDung = new TextBox();
            TxtDanhSachMailPassGui = new TextBox();
            DGVDanhSachMailPassGui = new DataGridView();
            TxtEmail = new TextBox();
            TxtPass = new TextBox();
            TxtTieuDeGui = new TextBox();
            TxtNoiDungGui = new TextBox();
            DGVTieuDeNoiDungGui = new DataGridView();
            label1 = new Label();
            NBLapLai = new NumericUpDown();
            label2 = new Label();
            NUThread = new NumericUpDown();
            CBTuDong = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            LBDaGui = new Label();
            LBThatBai = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            BtnGui = new Button();
            BtnDung = new Button();
            BtnThemNhieu = new Button();
            label14 = new Label();
            label15 = new Label();
            BtnThemMailGui = new Button();
            BtnXoaMailGui = new Button();
            BtnXoaHetMailGui = new Button();
            BtnMailLoi = new Button();
            BtnThemNoiDung = new Button();
            BtnXoaNoiDung = new Button();
            label6 = new Label();
            TxtTieuDeNoiDungGui = new Label();
            label17 = new Label();
            TxtGhiChuGui = new TextBox();
            NBThoiGianGui = new NumericUpDown();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVDanhSachMailPassGui).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVTieuDeNoiDungGui).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NBLapLai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUThread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NBThoiGianGui).BeginInit();
            SuspendLayout();
            // 
            // TxtMailNhan
            // 
            TxtMailNhan.Location = new Point(110, 155);
            TxtMailNhan.Multiline = true;
            TxtMailNhan.Name = "TxtMailNhan";
            TxtMailNhan.Size = new Size(277, 29);
            TxtMailNhan.TabIndex = 0;
            // 
            // TxtTieuDe
            // 
            TxtTieuDe.Location = new Point(110, 213);
            TxtTieuDe.Name = "TxtTieuDe";
            TxtTieuDe.Size = new Size(277, 23);
            TxtTieuDe.TabIndex = 1;
            // 
            // TxtNoiDung
            // 
            TxtNoiDung.Location = new Point(110, 279);
            TxtNoiDung.Multiline = true;
            TxtNoiDung.Name = "TxtNoiDung";
            TxtNoiDung.Size = new Size(277, 103);
            TxtNoiDung.TabIndex = 2;
            // 
            // TxtDanhSachMailPassGui
            // 
            TxtDanhSachMailPassGui.Location = new Point(501, 45);
            TxtDanhSachMailPassGui.Multiline = true;
            TxtDanhSachMailPassGui.Name = "TxtDanhSachMailPassGui";
            TxtDanhSachMailPassGui.Size = new Size(274, 46);
            TxtDanhSachMailPassGui.TabIndex = 3;
            // 
            // DGVDanhSachMailPassGui
            // 
            DGVDanhSachMailPassGui.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDanhSachMailPassGui.Location = new Point(501, 138);
            DGVDanhSachMailPassGui.Name = "DGVDanhSachMailPassGui";
            DGVDanhSachMailPassGui.RowTemplate.Height = 25;
            DGVDanhSachMailPassGui.Size = new Size(274, 206);
            DGVDanhSachMailPassGui.TabIndex = 4;
            DGVDanhSachMailPassGui.CellClick += DGVDanhSachMailPassGui_CellClick;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(501, 373);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(142, 23);
            TxtEmail.TabIndex = 5;
            TxtEmail.TextChanged += textBox5_TextChanged;
            // 
            // TxtPass
            // 
            TxtPass.Location = new Point(649, 373);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(157, 23);
            TxtPass.TabIndex = 6;
            // 
            // TxtTieuDeGui
            // 
            TxtTieuDeGui.Location = new Point(842, 54);
            TxtTieuDeGui.Multiline = true;
            TxtTieuDeGui.Name = "TxtTieuDeGui";
            TxtTieuDeGui.Size = new Size(461, 46);
            TxtTieuDeGui.TabIndex = 7;
            // 
            // TxtNoiDungGui
            // 
            TxtNoiDungGui.Location = new Point(842, 138);
            TxtNoiDungGui.Multiline = true;
            TxtNoiDungGui.Name = "TxtNoiDungGui";
            TxtNoiDungGui.Size = new Size(461, 114);
            TxtNoiDungGui.TabIndex = 8;
            TxtNoiDungGui.TextChanged += textBox8_TextChanged;
            // 
            // DGVTieuDeNoiDungGui
            // 
            DGVTieuDeNoiDungGui.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTieuDeNoiDungGui.Location = new Point(842, 486);
            DGVTieuDeNoiDungGui.Name = "DGVTieuDeNoiDungGui";
            DGVTieuDeNoiDungGui.RowTemplate.Height = 25;
            DGVTieuDeNoiDungGui.Size = new Size(461, 150);
            DGVTieuDeNoiDungGui.TabIndex = 9;
            DGVTieuDeNoiDungGui.CellClick += DGVTieuDeNoiDungGui_CellClick;
            DGVTieuDeNoiDungGui.CellContentClick += DGVTieuDeNoiDungGui_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 54);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 10;
            label1.Text = "Số lần lặp lại";
            label1.Click += label1_Click;
            // 
            // NBLapLai
            // 
            NBLapLai.Location = new Point(110, 52);
            NBLapLai.Name = "NBLapLai";
            NBLapLai.Size = new Size(38, 23);
            NBLapLai.TabIndex = 11;
            NBLapLai.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NBLapLai.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 54);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 12;
            label2.Text = "Số Thread";
            // 
            // NUThread
            // 
            NUThread.Location = new Point(362, 52);
            NUThread.Name = "NUThread";
            NUThread.Size = new Size(34, 23);
            NUThread.TabIndex = 13;
            NUThread.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CBTuDong
            // 
            CBTuDong.AutoSize = true;
            CBTuDong.Location = new Point(22, 97);
            CBTuDong.Name = "CBTuDong";
            CBTuDong.Size = new Size(162, 19);
            CBTuDong.TabIndex = 14;
            CBTuDong.Text = "Tự Điền Tiêu Đề Nội Dung";
            CBTuDong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 158);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 15;
            label3.Text = "Mail Nhận";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 216);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 16;
            label4.Text = "Tiêu Đề";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 313);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 17;
            label5.Text = "Nội Dung";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 486);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 19;
            label7.Text = "Gửi Thất Bại";
            // 
            // LBDaGui
            // 
            LBDaGui.AutoSize = true;
            LBDaGui.Location = new Point(110, 434);
            LBDaGui.Name = "LBDaGui";
            LBDaGui.Size = new Size(13, 15);
            LBDaGui.TabIndex = 20;
            LBDaGui.Text = "0";
            // 
            // LBThatBai
            // 
            LBThatBai.AutoSize = true;
            LBThatBai.Location = new Point(110, 486);
            LBThatBai.Name = "LBThatBai";
            LBThatBai.Size = new Size(13, 15);
            LBThatBai.TabIndex = 21;
            LBThatBai.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(501, 9);
            label10.Name = "label10";
            label10.Size = new Size(136, 15);
            label10.TabIndex = 22;
            label10.Text = "Danh Sách Mail Pass Gửi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(842, 36);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 23;
            label11.Text = "Tiêu Đề Gửi";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(842, 120);
            label12.Name = "label12";
            label12.Size = new Size(79, 15);
            label12.TabIndex = 24;
            label12.Text = "Nội Dung Gửi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(842, 467);
            label13.Name = "label13";
            label13.Size = new Size(121, 15);
            label13.TabIndex = 25;
            label13.Text = "Tiêu Đề Nội Dung Gửi";
            // 
            // BtnGui
            // 
            BtnGui.Location = new Point(260, 459);
            BtnGui.Name = "BtnGui";
            BtnGui.Size = new Size(51, 23);
            BtnGui.TabIndex = 26;
            BtnGui.Text = "Gửi";
            BtnGui.UseVisualStyleBackColor = true;
            BtnGui.Click += BtnGui_Click;
            // 
            // BtnDung
            // 
            BtnDung.Enabled = false;
            BtnDung.Location = new Point(336, 459);
            BtnDung.Name = "BtnDung";
            BtnDung.Size = new Size(51, 23);
            BtnDung.TabIndex = 27;
            BtnDung.Text = "Dừng";
            BtnDung.UseVisualStyleBackColor = true;
            BtnDung.Click += BtnDung_Click;
            // 
            // BtnThemNhieu
            // 
            BtnThemNhieu.Location = new Point(687, 97);
            BtnThemNhieu.Name = "BtnThemNhieu";
            BtnThemNhieu.Size = new Size(88, 23);
            BtnThemNhieu.TabIndex = 28;
            BtnThemNhieu.Text = "Thêm Nhiều";
            BtnThemNhieu.UseVisualStyleBackColor = true;
            BtnThemNhieu.Click += BtnThemNhieu_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(501, 355);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 29;
            label14.Text = "Email";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(649, 355);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 30;
            label15.Text = "Pass";
            // 
            // BtnThemMailGui
            // 
            BtnThemMailGui.Location = new Point(501, 415);
            BtnThemMailGui.Name = "BtnThemMailGui";
            BtnThemMailGui.Size = new Size(98, 23);
            BtnThemMailGui.TabIndex = 31;
            BtnThemMailGui.Text = "Thêm Mail Gửi";
            BtnThemMailGui.UseVisualStyleBackColor = true;
            BtnThemMailGui.Click += BtnThemMailGui_Click;
            // 
            // BtnXoaMailGui
            // 
            BtnXoaMailGui.Location = new Point(605, 415);
            BtnXoaMailGui.Name = "BtnXoaMailGui";
            BtnXoaMailGui.Size = new Size(89, 23);
            BtnXoaMailGui.TabIndex = 32;
            BtnXoaMailGui.Text = "Xóa Mail Gui";
            BtnXoaMailGui.UseVisualStyleBackColor = true;
            BtnXoaMailGui.Click += BtnXoaMailGui_Click;
            // 
            // BtnXoaHetMailGui
            // 
            BtnXoaHetMailGui.Location = new Point(700, 415);
            BtnXoaHetMailGui.Name = "BtnXoaHetMailGui";
            BtnXoaHetMailGui.Size = new Size(106, 23);
            BtnXoaHetMailGui.TabIndex = 33;
            BtnXoaHetMailGui.Text = "Xóa Hết Mail Gui";
            BtnXoaHetMailGui.UseVisualStyleBackColor = true;
            BtnXoaHetMailGui.Click += BtnXoaHetMailGui_Click;
            // 
            // BtnMailLoi
            // 
            BtnMailLoi.Location = new Point(591, 459);
            BtnMailLoi.Name = "BtnMailLoi";
            BtnMailLoi.Size = new Size(105, 23);
            BtnMailLoi.TabIndex = 34;
            BtnMailLoi.Text = "Mail Lỗi";
            BtnMailLoi.UseVisualStyleBackColor = true;
            // 
            // BtnThemNoiDung
            // 
            BtnThemNoiDung.Location = new Point(1198, 444);
            BtnThemNoiDung.Name = "BtnThemNoiDung";
            BtnThemNoiDung.Size = new Size(105, 23);
            BtnThemNoiDung.TabIndex = 35;
            BtnThemNoiDung.Text = "Thêm Nội Dung";
            BtnThemNoiDung.UseVisualStyleBackColor = true;
            BtnThemNoiDung.Click += BtnThemNoiDung_Click;
            // 
            // BtnXoaNoiDung
            // 
            BtnXoaNoiDung.Location = new Point(842, 642);
            BtnXoaNoiDung.Name = "BtnXoaNoiDung";
            BtnXoaNoiDung.Size = new Size(105, 23);
            BtnXoaNoiDung.TabIndex = 36;
            BtnXoaNoiDung.Text = "Xóa Nội Dung";
            BtnXoaNoiDung.UseVisualStyleBackColor = true;
            BtnXoaNoiDung.Click += BtnXoaNoiDung_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 434);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 18;
            label6.Text = "Email Đã Gửi";
            // 
            // TxtTieuDeNoiDungGui
            // 
            TxtTieuDeNoiDungGui.AutoSize = true;
            TxtTieuDeNoiDungGui.Location = new Point(842, 9);
            TxtTieuDeNoiDungGui.Name = "TxtTieuDeNoiDungGui";
            TxtTieuDeNoiDungGui.Size = new Size(121, 15);
            TxtTieuDeNoiDungGui.TabIndex = 37;
            TxtTieuDeNoiDungGui.Text = "Tiêu Đề Nội Dung Gửi";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(842, 266);
            label17.Name = "label17";
            label17.Size = new Size(71, 15);
            label17.TabIndex = 38;
            label17.Text = "Ghi Chú Gửi";
            // 
            // TxtGhiChuGui
            // 
            TxtGhiChuGui.Location = new Point(842, 286);
            TxtGhiChuGui.Multiline = true;
            TxtGhiChuGui.Name = "TxtGhiChuGui";
            TxtGhiChuGui.Size = new Size(461, 152);
            TxtGhiChuGui.TabIndex = 39;
            // 
            // NBThoiGianGui
            // 
            NBThoiGianGui.Location = new Point(336, 93);
            NBThoiGianGui.Name = "NBThoiGianGui";
            NBThoiGianGui.Size = new Size(64, 23);
            NBThoiGianGui.TabIndex = 40;
            NBThoiGianGui.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(233, 97);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 41;
            label8.Text = "Thời Gian Gửi (s)";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(label8);
            Controls.Add(NBThoiGianGui);
            Controls.Add(TxtGhiChuGui);
            Controls.Add(label17);
            Controls.Add(TxtTieuDeNoiDungGui);
            Controls.Add(BtnXoaNoiDung);
            Controls.Add(BtnThemNoiDung);
            Controls.Add(BtnMailLoi);
            Controls.Add(BtnXoaHetMailGui);
            Controls.Add(BtnXoaMailGui);
            Controls.Add(BtnThemMailGui);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(BtnThemNhieu);
            Controls.Add(BtnDung);
            Controls.Add(BtnGui);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(LBThatBai);
            Controls.Add(LBDaGui);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CBTuDong);
            Controls.Add(NUThread);
            Controls.Add(label2);
            Controls.Add(NBLapLai);
            Controls.Add(label1);
            Controls.Add(DGVTieuDeNoiDungGui);
            Controls.Add(TxtNoiDungGui);
            Controls.Add(TxtTieuDeGui);
            Controls.Add(TxtPass);
            Controls.Add(TxtEmail);
            Controls.Add(DGVDanhSachMailPassGui);
            Controls.Add(TxtDanhSachMailPassGui);
            Controls.Add(TxtNoiDung);
            Controls.Add(TxtTieuDe);
            Controls.Add(TxtMailNhan);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGVDanhSachMailPassGui).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVTieuDeNoiDungGui).EndInit();
            ((System.ComponentModel.ISupportInitialize)NBLapLai).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUThread).EndInit();
            ((System.ComponentModel.ISupportInitialize)NBThoiGianGui).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtMailNhan;
        private TextBox TxtTieuDe;
        private TextBox TxtNoiDung;
        private TextBox TxtDanhSachMailPassGui;
        private DataGridView DGVDanhSachMailPassGui;
        private TextBox TxtEmail;
        private TextBox TxtPass;
        private TextBox TxtTieuDeGui;
        private TextBox TxtNoiDungGui;
        private DataGridView DGVTieuDeNoiDungGui;
        private Label label1;
        private NumericUpDown NBLapLai;
        private Label label2;
        private NumericUpDown NUThread;
        private CheckBox CBTuDong;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label LBDaGui;
        private Label LBThatBai;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button BtnGui;
        private Button BtnDung;
        private Button BtnThemNhieu;
        private Label label14;
        private Label label15;
        private Button BtnThemMailGui;
        private Button BtnXoaMailGui;
        private Button BtnXoaHetMailGui;
        private Button BtnMailLoi;
        private Button BtnThemNoiDung;
        private Button BtnXoaNoiDung;
        private Label label6;
        private Label TxtTieuDeNoiDungGui;
        private Label label17;
        private TextBox TxtGhiChuGui;
        private NumericUpDown NBThoiGianGui;
        private Label label8;
    }
}
