namespace Bai7
{
    partial class DangKy
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
            MatKhauText = new TextBox();
            TenTaiKhoanText = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            LanguageCombo = new ComboBox();
            Female = new RadioButton();
            Male = new RadioButton();
            BirthdayDate = new DateTimePicker();
            PhoneText = new TextBox();
            LastNameText = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            FirstNameText = new TextBox();
            EmailText = new TextBox();
            NutClear = new Button();
            NutDangKy = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MatKhauText
            // 
            MatKhauText.Font = new Font("Segoe UI", 10F);
            MatKhauText.Location = new Point(184, 99);
            MatKhauText.Name = "MatKhauText";
            MatKhauText.PasswordChar = '*';
            MatKhauText.Size = new Size(461, 34);
            MatKhauText.TabIndex = 1;
            // 
            // TenTaiKhoanText
            // 
            TenTaiKhoanText.Font = new Font("Segoe UI", 10F);
            TenTaiKhoanText.Location = new Point(184, 31);
            TenTaiKhoanText.Name = "TenTaiKhoanText";
            TenTaiKhoanText.Size = new Size(461, 34);
            TenTaiKhoanText.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(MatKhauText);
            panel1.Controls.Add(TenTaiKhoanText);
            panel1.Location = new Point(33, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 158);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 99);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 5;
            label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 31);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 4;
            label2.Text = "Tên Tài Khoản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 41);
            label1.TabIndex = 3;
            label1.Text = "Hôm Nay Ăn Gì";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 56);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 4;
            label4.Text = "Sign Up";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 263);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 6;
            label5.Text = "User Information";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(LanguageCombo);
            panel2.Controls.Add(Female);
            panel2.Controls.Add(Male);
            panel2.Controls.Add(BirthdayDate);
            panel2.Controls.Add(PhoneText);
            panel2.Controls.Add(LastNameText);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(FirstNameText);
            panel2.Controls.Add(EmailText);
            panel2.Location = new Point(39, 279);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 420);
            panel2.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(120, 372);
            label12.Name = "label12";
            label12.Size = new Size(52, 28);
            label12.TabIndex = 18;
            label12.Text = "Sex:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(58, 320);
            label11.Name = "label11";
            label11.Size = new Size(114, 28);
            label11.TabIndex = 17;
            label11.Text = "Language:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(70, 261);
            label10.Name = "label10";
            label10.Size = new Size(102, 28);
            label10.TabIndex = 16;
            label10.Text = "Birthday:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(92, 202);
            label9.Name = "label9";
            label9.Size = new Size(80, 28);
            label9.TabIndex = 15;
            label9.Text = "Phone:";
            // 
            // LanguageCombo
            // 
            LanguageCombo.FormattingEnabled = true;
            LanguageCombo.Items.AddRange(new object[] { "English", "Vietnamese", "French", "Spanish", "German", "Italian", "Portuguese", "Russian", "Chinese", "Japanese", "Korean", "Arabic", "Hindi", "Thai", "Indonesian", "Malay", "Turkish", "Dutch", "Greek", "Polish", "Swedish", "Norwegian", "Danish", "Finnish", "Hebrew" });
            LanguageCombo.Location = new Point(184, 320);
            LanguageCombo.Name = "LanguageCombo";
            LanguageCombo.Size = new Size(463, 33);
            LanguageCombo.TabIndex = 14;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(285, 373);
            Female.Name = "Female";
            Female.Size = new Size(61, 29);
            Female.TabIndex = 13;
            Female.TabStop = true;
            Female.Text = "Nữ";
            Female.UseVisualStyleBackColor = true;
            Female.CheckedChanged += Female_CheckedChanged;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(184, 373);
            Male.Name = "Male";
            Male.Size = new Size(75, 29);
            Male.TabIndex = 12;
            Male.TabStop = true;
            Male.Text = "Nam";
            Male.UseVisualStyleBackColor = true;
            Male.CheckedChanged += Male_CheckedChanged;
            // 
            // BirthdayDate
            // 
            BirthdayDate.Location = new Point(184, 261);
            BirthdayDate.Name = "BirthdayDate";
            BirthdayDate.Size = new Size(461, 31);
            BirthdayDate.TabIndex = 10;
            // 
            // PhoneText
            // 
            PhoneText.Font = new Font("Segoe UI", 10F);
            PhoneText.Location = new Point(184, 202);
            PhoneText.Name = "PhoneText";
            PhoneText.Size = new Size(461, 34);
            PhoneText.TabIndex = 8;
            // 
            // LastNameText
            // 
            LastNameText.Font = new Font("Segoe UI", 10F);
            LastNameText.Location = new Point(184, 139);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(461, 34);
            LastNameText.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(66, 139);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 6;
            label8.Text = "Lastname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 80);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 5;
            label6.Text = "Firstname:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(107, 28);
            label7.Name = "label7";
            label7.Size = new Size(71, 28);
            label7.TabIndex = 4;
            label7.Text = "Email:";
            // 
            // FirstNameText
            // 
            FirstNameText.Font = new Font("Segoe UI", 10F);
            FirstNameText.Location = new Point(184, 77);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(461, 34);
            FirstNameText.TabIndex = 1;
            // 
            // EmailText
            // 
            EmailText.Font = new Font("Segoe UI", 10F);
            EmailText.Location = new Point(184, 25);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(461, 34);
            EmailText.TabIndex = 0;
            // 
            // NutClear
            // 
            NutClear.Location = new Point(432, 721);
            NutClear.Name = "NutClear";
            NutClear.Size = new Size(128, 32);
            NutClear.TabIndex = 7;
            NutClear.Text = "Clear";
            NutClear.UseVisualStyleBackColor = true;
            NutClear.Click += NutClear_Click;
            // 
            // NutDangKy
            // 
            NutDangKy.Location = new Point(583, 721);
            NutDangKy.Name = "NutDangKy";
            NutDangKy.Size = new Size(128, 32);
            NutDangKy.TabIndex = 8;
            NutDangKy.Text = "Sign In";
            NutDangKy.UseVisualStyleBackColor = true;
            NutDangKy.Click += NutDangKy_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 790);
            Controls.Add(NutDangKy);
            Controls.Add(NutClear);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "DangKy";
            Text = "Đăng Ký";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MatKhauText;
        private TextBox TenTaiKhoanText;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private TextBox textBox7;
        private TextBox PhoneText;
        private TextBox LastNameText;
        private Label label8;
        private Label label6;
        private Label label7;
        private TextBox FirstNameText;
        private TextBox EmailText;
        private ComboBox LanguageCombo;
        private RadioButton Female;
        private RadioButton Male;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private DateTimePicker BirthdayDate;
        private Button NutClear;
        private Button NutDangKy;
    }
}