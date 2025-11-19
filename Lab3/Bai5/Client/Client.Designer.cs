namespace Client
{
    partial class Client
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.lbQuyenHan = new System.Windows.Forms.Label();
            this.cbQuyenHan = new System.Windows.Forms.ComboBox();
            this.tbNguoiDongGop = new System.Windows.Forms.TextBox();
            this.lbNguoiDongGop = new System.Windows.Forms.Label();
            this.lbHinhAnh = new System.Windows.Forms.Label();
            this.btnThemHinhAnh = new System.Windows.Forms.Button();
            this.tbTenMonAn = new System.Windows.Forms.TextBox();
            this.lbTenMonAn = new System.Windows.Forms.Label();
            this.cbTuyChon = new System.Windows.Forms.ComboBox();
            this.lbKetQua = new System.Windows.Forms.ListBox();
            this.btnHomNayAnGi = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMonAn = new System.Windows.Forms.PictureBox();
            this.pBThemHinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBThemHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(850, 608);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 44);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThemMon.Location = new System.Drawing.Point(40, 249);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(196, 44);
            this.btnThemMon.TabIndex = 24;
            this.btnThemMon.Text = "Thêm món ăn";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // lbQuyenHan
            // 
            this.lbQuyenHan.AutoSize = true;
            this.lbQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbQuyenHan.Location = new System.Drawing.Point(35, 170);
            this.lbQuyenHan.Name = "lbQuyenHan";
            this.lbQuyenHan.Size = new System.Drawing.Size(128, 29);
            this.lbQuyenHan.TabIndex = 23;
            this.lbQuyenHan.Text = "Quyền hạn";
            // 
            // cbQuyenHan
            // 
            this.cbQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbQuyenHan.FormattingEnabled = true;
            this.cbQuyenHan.Items.AddRange(new object[] {
            "Người dùng",
            "Quản trị viên"});
            this.cbQuyenHan.Location = new System.Drawing.Point(219, 160);
            this.cbQuyenHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbQuyenHan.Name = "cbQuyenHan";
            this.cbQuyenHan.Size = new System.Drawing.Size(136, 37);
            this.cbQuyenHan.TabIndex = 22;
            // 
            // tbNguoiDongGop
            // 
            this.tbNguoiDongGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNguoiDongGop.Location = new System.Drawing.Point(219, 101);
            this.tbNguoiDongGop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNguoiDongGop.Name = "tbNguoiDongGop";
            this.tbNguoiDongGop.Size = new System.Drawing.Size(214, 35);
            this.tbNguoiDongGop.TabIndex = 21;
            // 
            // lbNguoiDongGop
            // 
            this.lbNguoiDongGop.AutoSize = true;
            this.lbNguoiDongGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNguoiDongGop.Location = new System.Drawing.Point(35, 101);
            this.lbNguoiDongGop.Name = "lbNguoiDongGop";
            this.lbNguoiDongGop.Size = new System.Drawing.Size(187, 29);
            this.lbNguoiDongGop.TabIndex = 20;
            this.lbNguoiDongGop.Text = "Người đóng góp";
            // 
            // lbHinhAnh
            // 
            this.lbHinhAnh.AutoSize = true;
            this.lbHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHinhAnh.Location = new System.Drawing.Point(506, 120);
            this.lbHinhAnh.Name = "lbHinhAnh";
            this.lbHinhAnh.Size = new System.Drawing.Size(107, 29);
            this.lbHinhAnh.TabIndex = 18;
            this.lbHinhAnh.Text = "Hình ảnh";
            // 
            // btnThemHinhAnh
            // 
            this.btnThemHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThemHinhAnh.Location = new System.Drawing.Point(512, 166);
            this.btnThemHinhAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemHinhAnh.Name = "btnThemHinhAnh";
            this.btnThemHinhAnh.Size = new System.Drawing.Size(93, 42);
            this.btnThemHinhAnh.TabIndex = 17;
            this.btnThemHinhAnh.Text = "Add";
            this.btnThemHinhAnh.UseVisualStyleBackColor = true;
            this.btnThemHinhAnh.Click += new System.EventHandler(this.btnThemHinhAnh_Click);
            // 
            // tbTenMonAn
            // 
            this.tbTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTenMonAn.Location = new System.Drawing.Point(691, 58);
            this.tbTenMonAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenMonAn.Name = "tbTenMonAn";
            this.tbTenMonAn.Size = new System.Drawing.Size(214, 35);
            this.tbTenMonAn.TabIndex = 16;
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.AutoSize = true;
            this.lbTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTenMonAn.Location = new System.Drawing.Point(506, 64);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(141, 29);
            this.lbTenMonAn.TabIndex = 15;
            this.lbTenMonAn.Text = "Tên món ăn";
            // 
            // cbTuyChon
            // 
            this.cbTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTuyChon.FormattingEnabled = true;
            this.cbTuyChon.Location = new System.Drawing.Point(297, 251);
            this.cbTuyChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTuyChon.Name = "cbTuyChon";
            this.cbTuyChon.Size = new System.Drawing.Size(163, 37);
            this.cbTuyChon.TabIndex = 33;
            this.cbTuyChon.SelectedIndexChanged += new System.EventHandler(this.cbTuyChon_SelectedIndexChanged_1);
            // 
            // lbKetQua
            // 
            this.lbKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbKetQua.FormattingEnabled = true;
            this.lbKetQua.ItemHeight = 20;
            this.lbKetQua.Location = new System.Drawing.Point(241, 358);
            this.lbKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(312, 204);
            this.lbKetQua.TabIndex = 32;
            this.lbKetQua.SelectedIndexChanged += new System.EventHandler(this.lbKetQua_SelectedIndexChanged);
            // 
            // btnHomNayAnGi
            // 
            this.btnHomNayAnGi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHomNayAnGi.Location = new System.Drawing.Point(40, 430);
            this.btnHomNayAnGi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHomNayAnGi.Name = "btnHomNayAnGi";
            this.btnHomNayAnGi.Size = new System.Drawing.Size(163, 44);
            this.btnHomNayAnGi.TabIndex = 31;
            this.btnHomNayAnGi.Text = "Hôm nay ăn gì";
            this.btnHomNayAnGi.UseVisualStyleBackColor = true;
            this.btnHomNayAnGi.Click += new System.EventHandler(this.btnHomNayAnGi_Click);
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbID.Location = new System.Drawing.Point(219, 56);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(214, 35);
            this.tbID.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID ";
            // 
            // pictureBoxMonAn
            // 
            this.pictureBoxMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxMonAn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxMonAn.Location = new System.Drawing.Point(611, 358);
            this.pictureBoxMonAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxMonAn.Name = "pictureBoxMonAn";
            this.pictureBoxMonAn.Size = new System.Drawing.Size(339, 224);
            this.pictureBoxMonAn.TabIndex = 26;
            this.pictureBoxMonAn.TabStop = false;
            this.pictureBoxMonAn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pBThemHinhAnh
            // 
            this.pBThemHinhAnh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pBThemHinhAnh.Location = new System.Drawing.Point(691, 120);
            this.pBThemHinhAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBThemHinhAnh.Name = "pBThemHinhAnh";
            this.pBThemHinhAnh.Size = new System.Drawing.Size(214, 125);
            this.pBThemHinhAnh.TabIndex = 19;
            this.pBThemHinhAnh.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 666);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTuyChon);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btnHomNayAnGi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBoxMonAn);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.lbQuyenHan);
            this.Controls.Add(this.cbQuyenHan);
            this.Controls.Add(this.tbNguoiDongGop);
            this.Controls.Add(this.lbNguoiDongGop);
            this.Controls.Add(this.pBThemHinhAnh);
            this.Controls.Add(this.lbHinhAnh);
            this.Controls.Add(this.btnThemHinhAnh);
            this.Controls.Add(this.tbTenMonAn);
            this.Controls.Add(this.lbTenMonAn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBThemHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxMonAn;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label lbQuyenHan;
        private System.Windows.Forms.ComboBox cbQuyenHan;
        private System.Windows.Forms.TextBox tbNguoiDongGop;
        private System.Windows.Forms.Label lbNguoiDongGop;
        private System.Windows.Forms.PictureBox pBThemHinhAnh;
        private System.Windows.Forms.Label lbHinhAnh;
        private System.Windows.Forms.Button btnThemHinhAnh;
        private System.Windows.Forms.TextBox tbTenMonAn;
        private System.Windows.Forms.Label lbTenMonAn;
        private System.Windows.Forms.ComboBox cbTuyChon;
        private System.Windows.Forms.ListBox lbKetQua;
        private System.Windows.Forms.Button btnHomNayAnGi;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
    }
}

