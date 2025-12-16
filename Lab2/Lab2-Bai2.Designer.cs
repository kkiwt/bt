namespace Lab02
{
    partial class Lab2_Bai2
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
            DocFile = new Button();
            FileName = new TextBox();
            Size = new TextBox();
            CharacterCount = new TextBox();
            URL = new TextBox();
            WordsCount = new TextBox();
            LineCount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Thoat = new Button();
            SuspendLayout();
            // 
            // BangNoiDung
            // 
            BangNoiDung.Location = new Point(399, 15);
            BangNoiDung.Margin = new Padding(3, 4, 3, 4);
            BangNoiDung.Name = "BangNoiDung";
            BangNoiDung.ReadOnly = true;
            BangNoiDung.Size = new Size(707, 517);
            BangNoiDung.TabIndex = 0;
            BangNoiDung.Text = "";
            BangNoiDung.TextChanged += BangNoiDung_TextChanged;
            // 
            // DocFile
            // 
            DocFile.Location = new Point(89, 15);
            DocFile.Margin = new Padding(3, 4, 3, 4);
            DocFile.Name = "DocFile";
            DocFile.Size = new Size(220, 75);
            DocFile.TabIndex = 1;
            DocFile.Text = "Đọc File";
            DocFile.UseVisualStyleBackColor = true;
            DocFile.Click += DocFile_Click;
            // 
            // FileName
            // 
            FileName.Location = new Point(89, 116);
            FileName.Margin = new Padding(3, 4, 3, 4);
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            FileName.Size = new Size(220, 31);
            FileName.TabIndex = 2;
            // 
            // Size
            // 
            Size.Location = new Point(118, 196);
            Size.Margin = new Padding(3, 4, 3, 4);
            Size.Name = "Size";
            Size.ReadOnly = true;
            Size.Size = new Size(191, 31);
            Size.TabIndex = 3;
            // 
            // CharacterCount
            // 
            CharacterCount.Location = new Point(118, 518);
            CharacterCount.Margin = new Padding(3, 4, 3, 4);
            CharacterCount.Name = "CharacterCount";
            CharacterCount.ReadOnly = true;
            CharacterCount.Size = new Size(220, 31);
            CharacterCount.TabIndex = 4;
            // 
            // URL
            // 
            URL.Location = new Point(89, 282);
            URL.Margin = new Padding(3, 4, 3, 4);
            URL.Name = "URL";
            URL.ReadOnly = true;
            URL.Size = new Size(275, 31);
            URL.TabIndex = 5;
            // 
            // WordsCount
            // 
            WordsCount.Location = new Point(118, 450);
            WordsCount.Margin = new Padding(3, 4, 3, 4);
            WordsCount.Name = "WordsCount";
            WordsCount.ReadOnly = true;
            WordsCount.Size = new Size(220, 31);
            WordsCount.TabIndex = 6;
            // 
            // LineCount
            // 
            LineCount.Location = new Point(118, 371);
            LineCount.Margin = new Padding(3, 4, 3, 4);
            LineCount.Name = "LineCount";
            LineCount.ReadOnly = true;
            LineCount.Size = new Size(220, 31);
            LineCount.TabIndex = 7;
            LineCount.TextChanged += LineCount_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 119);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 8;
            label1.Text = "Tên File:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 196);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 9;
            label2.Text = "Kích Thước:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 285);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 10;
            label3.Text = "URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 377);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 11;
            label4.Text = "Số Dòng:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 453);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 12;
            label5.Text = "Số Chữ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 521);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 13;
            label6.Text = "Số Ký Tự:";
            // 
            // Thoat
            // 
            Thoat.Location = new Point(701, 545);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 14;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Lab2_Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1118, 593);
            Controls.Add(Thoat);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LineCount);
            Controls.Add(WordsCount);
            Controls.Add(URL);
            Controls.Add(CharacterCount);
            Controls.Add(Size);
            Controls.Add(FileName);
            Controls.Add(DocFile);
            Controls.Add(BangNoiDung);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab2_Bai2";
            Text = "Lab2_Bai2";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox BangNoiDung;
        private System.Windows.Forms.Button DocFile;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.TextBox CharacterCount;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox WordsCount;
        private System.Windows.Forms.TextBox LineCount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Thoat;
    }
}