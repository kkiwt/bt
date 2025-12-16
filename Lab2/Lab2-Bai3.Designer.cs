namespace Lab02
{
    partial class Lab2_Bai3
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
            BangNoiDung = new RichTextBox();
            Doc = new Button();
            Ghi = new Button();
            Thoat = new Button();
            SuspendLayout();
            // 
            // BangNoiDung
            // 
            BangNoiDung.Location = new Point(311, 76);
            BangNoiDung.Margin = new Padding(3, 4, 3, 4);
            BangNoiDung.Name = "BangNoiDung";
            BangNoiDung.ReadOnly = true;
            BangNoiDung.Size = new Size(498, 384);
            BangNoiDung.TabIndex = 1;
            BangNoiDung.Text = "";
            BangNoiDung.TextChanged += BangNoiDung_TextChanged;
            // 
            // Doc
            // 
            Doc.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            Doc.FlatAppearance.BorderSize = 2;
            Doc.Location = new Point(80, 91);
            Doc.Margin = new Padding(3, 4, 3, 4);
            Doc.Name = "Doc";
            Doc.Size = new Size(184, 99);
            Doc.TabIndex = 2;
            Doc.Text = "Đọc";
            Doc.UseVisualStyleBackColor = true;
            Doc.Click += Doc_Click;
            // 
            // Ghi
            // 
            Ghi.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            Ghi.FlatAppearance.BorderSize = 2;
            Ghi.Location = new Point(80, 329);
            Ghi.Margin = new Padding(3, 4, 3, 4);
            Ghi.Name = "Ghi";
            Ghi.Size = new Size(184, 99);
            Ghi.TabIndex = 3;
            Ghi.Text = "Ghi Phép Tính";
            Ghi.UseVisualStyleBackColor = true;
            Ghi.Click += Ghi_Click;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(491, 481);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 13;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Lab2_Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(889, 562);
            Controls.Add(Thoat);
            Controls.Add(Ghi);
            Controls.Add(Doc);
            Controls.Add(BangNoiDung);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab2_Bai3";
            Text = "Lab2_Bai3";
            Load += Lab2_Bai3_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox BangNoiDung;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Ghi;
        private Button Thoat;
    }
}