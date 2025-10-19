namespace Lab2
{
    partial class Bai8
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
            MonAnVao = new TextBox();
            label1 = new Label();
            KetQua = new TextBox();
            label2 = new Label();
            Thoat = new Button();
            Tim = new Button();
            Xoa = new Button();
            Them = new Button();
            BangThucAnList = new ListView();
            ID = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            HinhAnhMonAn = new PictureBox();
            NguoiDongGop = new Label();
            TenNguoiDongGop = new TextBox();
            label3 = new Label();
            ThemAnh = new Button();
            AnhChen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HinhAnhMonAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnhChen).BeginInit();
            SuspendLayout();
            // 
            // MonAnVao
            // 
            MonAnVao.Location = new Point(61, 75);
            MonAnVao.Name = "MonAnVao";
            MonAnVao.Size = new Size(308, 31);
            MonAnVao.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 41);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 2;
            label1.Text = "Nhập Món Ăn:";
            // 
            // KetQua
            // 
            KetQua.Location = new Point(233, 436);
            KetQua.Name = "KetQua";
            KetQua.ReadOnly = true;
            KetQua.Size = new Size(560, 31);
            KetQua.TabIndex = 3;
            KetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 442);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 4;
            label2.Text = "Món Ăn Buổi Này Là:";
            // 
            // Thoat
            // 
            Thoat.Location = new Point(61, 403);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 12;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Tim
            // 
            Tim.Location = new Point(61, 349);
            Tim.Name = "Tim";
            Tim.Size = new Size(141, 36);
            Tim.TabIndex = 13;
            Tim.Text = "Tìm Món Ăn";
            Tim.UseVisualStyleBackColor = true;
            Tim.Click += Tim_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(61, 296);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(141, 36);
            Xoa.TabIndex = 14;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Them
            // 
            Them.Location = new Point(61, 238);
            Them.Name = "Them";
            Them.Size = new Size(141, 36);
            Them.TabIndex = 15;
            Them.Text = "Thêm";
            Them.UseVisualStyleBackColor = true;
            Them.Click += Them_Click;
            // 
            // BangThucAnList
            // 
            BangThucAnList.Columns.AddRange(new ColumnHeader[] { ID, columnHeader1, columnHeader2 });
            BangThucAnList.Location = new Point(422, 24);
            BangThucAnList.Name = "BangThucAnList";
            BangThucAnList.Size = new Size(553, 361);
            BangThucAnList.TabIndex = 17;
            BangThucAnList.UseCompatibleStateImageBehavior = false;
            BangThucAnList.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Món Ăn";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Người Đóng Góp";
            columnHeader2.Width = 180;
            // 
            // HinhAnhMonAn
            // 
            HinhAnhMonAn.Location = new Point(814, 417);
            HinhAnhMonAn.Name = "HinhAnhMonAn";
            HinhAnhMonAn.Size = new Size(194, 87);
            HinhAnhMonAn.TabIndex = 18;
            HinhAnhMonAn.TabStop = false;
            // 
            // NguoiDongGop
            // 
            NguoiDongGop.AutoSize = true;
            NguoiDongGop.Location = new Point(369, 490);
            NguoiDongGop.Name = "NguoiDongGop";
            NguoiDongGop.Size = new Size(151, 25);
            NguoiDongGop.TabIndex = 19;
            NguoiDongGop.Text = "Người Đóng Góp";
            // 
            // TenNguoiDongGop
            // 
            TenNguoiDongGop.Location = new Point(61, 157);
            TenNguoiDongGop.Name = "TenNguoiDongGop";
            TenNguoiDongGop.Size = new Size(308, 31);
            TenNguoiDongGop.TabIndex = 20;
            TenNguoiDongGop.TextChanged += TenNguoiDongGop_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 129);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 21;
            label3.Text = "Nhập Tên Của Bạn:";
            // 
            // ThemAnh
            // 
            ThemAnh.Location = new Point(61, 194);
            ThemAnh.Name = "ThemAnh";
            ThemAnh.Size = new Size(141, 34);
            ThemAnh.TabIndex = 22;
            ThemAnh.Text = "Chèn Ảnh";
            ThemAnh.UseVisualStyleBackColor = true;
            ThemAnh.Click += ThemAnh_Click;
            // 
            // AnhChen
            // 
            AnhChen.Location = new Point(208, 194);
            AnhChen.Name = "AnhChen";
            AnhChen.Size = new Size(194, 87);
            AnhChen.SizeMode = PictureBoxSizeMode.StretchImage;
            AnhChen.TabIndex = 23;
            AnhChen.TabStop = false;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1050, 569);
            Controls.Add(AnhChen);
            Controls.Add(ThemAnh);
            Controls.Add(label3);
            Controls.Add(TenNguoiDongGop);
            Controls.Add(NguoiDongGop);
            Controls.Add(HinhAnhMonAn);
            Controls.Add(BangThucAnList);
            Controls.Add(Them);
            Controls.Add(Xoa);
            Controls.Add(Tim);
            Controls.Add(Thoat);
            Controls.Add(label2);
            Controls.Add(KetQua);
            Controls.Add(label1);
            Controls.Add(MonAnVao);
            Name = "Bai8";
            Text = "Bai8";
            Load += Bai8_Load;
            ((System.ComponentModel.ISupportInitialize)HinhAnhMonAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnhChen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox MonAnVao;
        private Label label1;
        private TextBox KetQua;
        private Label label2;
        private Button Thoat;
        private Button Tim;
        private Button Xoa;
        private Button Them;
        private ListBox BangThucAn;
        private ListView BangThucAnList;
        private PictureBox HinhAnhMonAn;
        private Label NguoiDongGop;
        private TextBox TenNguoiDongGop;
        private Label label3;
        private Button ThemAnh;
        private PictureBox AnhChen;
        private ColumnHeader ID;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}