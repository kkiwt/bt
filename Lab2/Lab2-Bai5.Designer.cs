
namespace Lab02
{
    partial class Bai4
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
            Phim = new ComboBox();
            PhongChieu = new ComboBox();
            HoTen = new TextBox();
            GheA = new CheckedListBox();
            GheB = new CheckedListBox();
            GheC = new CheckedListBox();
            KetQua = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Thoat = new Button();
            ThanhToan = new Button();
            Doc = new Button();
            Ghi = new Button();
            ThongKe = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // Phim
            // 
            Phim.FormattingEnabled = true;
            Phim.Location = new Point(247, 97);
            Phim.Name = "Phim";
            Phim.Size = new Size(402, 33);
            Phim.TabIndex = 0;
            Phim.SelectedIndexChanged += Phim_SelectedIndexChanged;
            // 
            // PhongChieu
            // 
            PhongChieu.FormattingEnabled = true;
            PhongChieu.Location = new Point(307, 163);
            PhongChieu.Name = "PhongChieu";
            PhongChieu.Size = new Size(342, 33);
            PhongChieu.TabIndex = 1;
            PhongChieu.SelectedIndexChanged += PhongChieu_SelectedIndexChanged;
            // 
            // HoTen
            // 
            HoTen.Location = new Point(247, 44);
            HoTen.Name = "HoTen";
            HoTen.Size = new Size(402, 31);
            HoTen.TabIndex = 2;
            // 
            // GheA
            // 
            GheA.FormattingEnabled = true;
            GheA.Location = new Point(128, 241);
            GheA.MultiColumn = true;
            GheA.Name = "GheA";
            GheA.Size = new Size(894, 60);
            GheA.TabIndex = 3;
            GheA.SelectedIndexChanged += GheA_SelectedIndexChanged;
            // 
            // GheB
            // 
            GheB.FormattingEnabled = true;
            GheB.Location = new Point(128, 308);
            GheB.MultiColumn = true;
            GheB.Name = "GheB";
            GheB.Size = new Size(894, 60);
            GheB.TabIndex = 4;
            // 
            // GheC
            // 
            GheC.FormattingEnabled = true;
            GheC.Location = new Point(128, 379);
            GheC.MultiColumn = true;
            GheC.Name = "GheC";
            GheC.Size = new Size(894, 60);
            GheC.TabIndex = 5;
            // 
            // KetQua
            // 
            KetQua.AutoSize = true;
            KetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KetQua.Location = new Point(702, 456);
            KetQua.Name = "KetQua";
            KetQua.Size = new Size(86, 25);
            KetQua.TabIndex = 6;
            KetQua.Text = "Kết Quả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 166);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 8;
            label1.Text = "Chọn Phòng Chiếu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 100);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 9;
            label2.Text = "Chọn Phim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 50);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 10;
            label3.Text = "Họ Tên";
            // 
            // Thoat
            // 
            Thoat.Location = new Point(212, 445);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 12;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // ThanhToan
            // 
            ThanhToan.Location = new Point(494, 456);
            ThanhToan.Name = "ThanhToan";
            ThanhToan.Size = new Size(155, 58);
            ThanhToan.TabIndex = 13;
            ThanhToan.Text = "Thanh Toán";
            ThanhToan.UseVisualStyleBackColor = true;
            ThanhToan.Click += MuaVe_Click;
            // 
            // Doc
            // 
            Doc.Location = new Point(1057, 147);
            Doc.Name = "Doc";
            Doc.Size = new Size(194, 63);
            Doc.TabIndex = 14;
            Doc.Text = "Đọc File ";
            Doc.UseVisualStyleBackColor = true;
            Doc.Click += Doc_Click;
            // 
            // Ghi
            // 
            Ghi.Location = new Point(1057, 268);
            Ghi.Name = "Ghi";
            Ghi.Size = new Size(194, 63);
            Ghi.TabIndex = 15;
            Ghi.Text = "Ghi File ";
            Ghi.UseVisualStyleBackColor = true;
            Ghi.Click += Ghi_Click;
            // 
            // ThongKe
            // 
            ThongKe.Location = new Point(1057, 395);
            ThongKe.Name = "ThongKe";
            ThongKe.Size = new Size(194, 63);
            ThongKe.TabIndex = 16;
            ThongKe.Text = "Thống Kê";
            ThongKe.UseVisualStyleBackColor = true;
            ThongKe.Click += ThongKe_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1280, 268);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(198, 67);
            progressBar1.TabIndex = 17;
            progressBar1.Visible = false;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1581, 689);
            Controls.Add(progressBar1);
            Controls.Add(ThongKe);
            Controls.Add(Ghi);
            Controls.Add(Doc);
            Controls.Add(ThanhToan);
            Controls.Add(Thoat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KetQua);
            Controls.Add(GheC);
            Controls.Add(GheB);
            Controls.Add(GheA);
            Controls.Add(HoTen);
            Controls.Add(PhongChieu);
            Controls.Add(Phim);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Phim;
        private ComboBox PhongChieu;
        private TextBox HoTen;

        private CheckedListBox GheA;
        private CheckedListBox GheB;
        private CheckedListBox GheC;
        private Label KetQua;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Thoat;
        private Button ThanhToan;
        private Button Doc;
        private Button Ghi;
        private Button ThongKe;
        private ProgressBar progressBar1;
    }
}