namespace Bai7
{
    partial class DangNhap
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
            label1 = new Label();
            MatKhauText = new TextBox();
            TaiKhoanText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NutDangNhap = new Button();
            DangKyLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 45);
            label1.Name = "label1";
            label1.Size = new Size(324, 54);
            label1.TabIndex = 0;
            label1.Text = "Hôm Nay Ăn Gì";
            // 
            // MatKhauText
            // 
            MatKhauText.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MatKhauText.Location = new Point(199, 194);
            MatKhauText.Name = "MatKhauText";
            MatKhauText.PasswordChar = '*';
            MatKhauText.Size = new Size(379, 39);
            MatKhauText.TabIndex = 1;
            // 
            // TaiKhoanText
            // 
            TaiKhoanText.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaiKhoanText.Location = new Point(199, 119);
            TaiKhoanText.Name = "TaiKhoanText";
            TaiKhoanText.Size = new Size(379, 39);
            TaiKhoanText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.Location = new Point(33, 125);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên Tài Khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.Location = new Point(80, 200);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 4;
            label3.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 250);
            label4.Name = "label4";
            label4.Size = new Size(226, 25);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account yet?";
            // 
            // NutDangNhap
            // 
            NutDangNhap.Location = new Point(617, 119);
            NutDangNhap.Name = "NutDangNhap";
            NutDangNhap.Size = new Size(133, 114);
            NutDangNhap.TabIndex = 6;
            NutDangNhap.Text = "Login";
            NutDangNhap.UseVisualStyleBackColor = true;
            NutDangNhap.Click += NutDangNhap_Click;
            // 
            // DangKyLabel
            // 
            DangKyLabel.AutoSize = true;
            DangKyLabel.ForeColor = Color.Blue;
            DangKyLabel.Location = new Point(555, 250);
            DangKyLabel.Name = "DangKyLabel";
            DangKyLabel.Size = new Size(78, 25);
            DangKyLabel.TabIndex = 7;
            DangKyLabel.Text = "Đăng Ký";
            DangKyLabel.Click += DangKyLabel_Click;
            DangKyLabel.MouseEnter += DangKyLabel_MouseEnter;
            DangKyLabel.MouseLeave += DangKyLabel_MouseLeave;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 356);
            Controls.Add(DangKyLabel);
            Controls.Add(NutDangNhap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TaiKhoanText);
            Controls.Add(MatKhauText);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MatKhauText;
        private TextBox TaiKhoanText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button NutDangNhap;
        private Label DangKyLabel;
    }
}