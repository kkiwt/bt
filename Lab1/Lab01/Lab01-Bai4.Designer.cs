namespace Lab01
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
            MuaVe = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Thoat = new Button();
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
            GheA.Size = new Size(870, 32);
            GheA.TabIndex = 3;
            GheA.SelectedIndexChanged += GheA_SelectedIndexChanged;
            // 
            // GheB
            // 
            GheB.FormattingEnabled = true;
            GheB.Location = new Point(128, 308);
            GheB.MultiColumn = true;
            GheB.Name = "GheB";
            GheB.Size = new Size(870, 32);
            GheB.TabIndex = 4;
            // 
            // GheC
            // 
            GheC.FormattingEnabled = true;
            GheC.Location = new Point(128, 379);
            GheC.MultiColumn = true;
            GheC.Name = "GheC";
            GheC.Size = new Size(870, 32);
            GheC.TabIndex = 5;
            // 
            // KetQua
            // 
            KetQua.AutoSize = true;
            KetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KetQua.Location = new Point(638, 414);
            KetQua.Name = "KetQua";
            KetQua.Size = new Size(86, 25);
            KetQua.TabIndex = 6;
            KetQua.Text = "Kết Quả:";
            KetQua.Click += KetQua_Click;
            // 
            // MuaVe
            // 
            MuaVe.Location = new Point(489, 445);
            MuaVe.Name = "MuaVe";
            MuaVe.Size = new Size(112, 34);
            MuaVe.TabIndex = 7;
            MuaVe.Text = "Tìm";
            MuaVe.UseVisualStyleBackColor = true;
            MuaVe.Click += MuaVe_Click;
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
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1055, 679);
            Controls.Add(Thoat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MuaVe);
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
        private Button MuaVe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Thoat;
    }
}