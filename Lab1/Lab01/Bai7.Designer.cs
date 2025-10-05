namespace Lab01
{
    partial class Bai7
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
            DuLieuNhap = new TextBox();
            label1 = new Label();
            PhanTich = new Button();
            KetQua = new TextBox();
            Thoat = new Button();
            SuspendLayout();
            // 
            // DuLieuNhap
            // 
            DuLieuNhap.Location = new Point(80, 93);
            DuLieuNhap.Name = "DuLieuNhap";
            DuLieuNhap.Size = new Size(953, 31);
            DuLieuNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 42);
            label1.Name = "label1";
            label1.Size = new Size(635, 32);
            label1.TabIndex = 1;
            label1.Text = "Nhập Theo Format: (Tên, điểm môn 1, điểm môn 2,...):";
            // 
            // PhanTich
            // 
            PhanTich.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhanTich.Location = new Point(80, 149);
            PhanTich.Name = "PhanTich";
            PhanTich.Size = new Size(112, 34);
            PhanTich.TabIndex = 2;
            PhanTich.Text = "Phân Tích";
            PhanTich.UseVisualStyleBackColor = true;
            PhanTich.Click += PhanTich_Click;
            // 
            // KetQua
            // 
            KetQua.Location = new Point(80, 205);
            KetQua.Multiline = true;
            KetQua.Name = "KetQua";
            KetQua.ReadOnly = true;
            KetQua.Size = new Size(953, 364);
            KetQua.TabIndex = 3;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(80, 585);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 12;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1066, 613);
            Controls.Add(Thoat);
            Controls.Add(KetQua);
            Controls.Add(PhanTich);
            Controls.Add(label1);
            Controls.Add(DuLieuNhap);
            Name = "Bai7";
            Text = "Bai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DuLieuNhap;
        private Label label1;
        private Button PhanTich;
        private TextBox KetQua;
        private Button Thoat;
    }
}