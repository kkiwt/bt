namespace Lab01
{
    partial class Bai6
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
            NgayThangNamSinh = new DateTimePicker();
            label1 = new Label();
            NutTim = new Button();
            KetQua = new Label();
            Thoat = new Button();
            SuspendLayout();
            // 
            // NgayThangNamSinh
            // 
            NgayThangNamSinh.Location = new Point(163, 89);
            NgayThangNamSinh.Name = "NgayThangNamSinh";
            NgayThangNamSinh.Size = new Size(318, 31);
            NgayThangNamSinh.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 56);
            label1.Name = "label1";
            label1.Size = new Size(286, 30);
            label1.TabIndex = 1;
            label1.Text = "Chọn Ngày Sinh Của Bạn:";
            // 
            // NutTim
            // 
            NutTim.BackColor = Color.Honeydew;
            NutTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutTim.ForeColor = SystemColors.ActiveCaptionText;
            NutTim.Location = new Point(163, 145);
            NutTim.Name = "NutTim";
            NutTim.Size = new Size(318, 34);
            NutTim.TabIndex = 2;
            NutTim.Text = "Tìm Cung Hoàng Đạo Của Bạn";
            NutTim.UseVisualStyleBackColor = false;
            NutTim.Click += NutTim_Click;
            // 
            // KetQua
            // 
            KetQua.AutoSize = true;
            KetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KetQua.Location = new Point(163, 198);
            KetQua.Name = "KetQua";
            KetQua.Size = new Size(259, 25);
            KetQua.TabIndex = 3;
            KetQua.Text = "Cung Hoàng Đạo của bạn là: ";
            // 
            // Thoat
            // 
            Thoat.Location = new Point(281, 362);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 12;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(717, 450);
            Controls.Add(Thoat);
            Controls.Add(KetQua);
            Controls.Add(NutTim);
            Controls.Add(label1);
            Controls.Add(NgayThangNamSinh);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker NgayThangNamSinh;
        private Label label1;
        private Button NutTim;
        private Label KetQua;
        private Button Thoat;
    }
}