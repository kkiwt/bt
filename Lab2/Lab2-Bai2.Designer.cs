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
            this.BangNoiDung = new System.Windows.Forms.RichTextBox();
            this.DocFile = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Size = new System.Windows.Forms.TextBox();
            this.CharacterCount = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.WordsCount = new System.Windows.Forms.TextBox();
            this.LineCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BangNoiDung
            // 
            this.BangNoiDung.Location = new System.Drawing.Point(359, 12);
            this.BangNoiDung.Name = "BangNoiDung";
            this.BangNoiDung.Size = new System.Drawing.Size(429, 406);
            this.BangNoiDung.TabIndex = 0;
            this.BangNoiDung.Text = "";
            this.BangNoiDung.TextChanged += new System.EventHandler(this.BangNoiDung_TextChanged);
            // 
            // DocFile
            // 
            this.DocFile.Location = new System.Drawing.Point(80, 12);
            this.DocFile.Name = "DocFile";
            this.DocFile.Size = new System.Drawing.Size(198, 60);
            this.DocFile.TabIndex = 1;
            this.DocFile.Text = "button1";
            this.DocFile.UseVisualStyleBackColor = true;
            this.DocFile.Click += new System.EventHandler(this.DocFile_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(80, 108);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(198, 26);
            this.FileName.TabIndex = 2;
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(80, 157);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(198, 26);
            this.Size.TabIndex = 3;
            // 
            // CharacterCount
            // 
            this.CharacterCount.Location = new System.Drawing.Point(80, 412);
            this.CharacterCount.Name = "CharacterCount";
            this.CharacterCount.Size = new System.Drawing.Size(198, 26);
            this.CharacterCount.TabIndex = 4;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(80, 228);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(198, 26);
            this.URL.TabIndex = 5;
            // 
            // WordsCount
            // 
            this.WordsCount.Location = new System.Drawing.Point(80, 362);
            this.WordsCount.Name = "WordsCount";
            this.WordsCount.Size = new System.Drawing.Size(198, 26);
            this.WordsCount.TabIndex = 6;
            // 
            // LineCount
            // 
            this.LineCount.Location = new System.Drawing.Point(80, 297);
            this.LineCount.Name = "LineCount";
            this.LineCount.Size = new System.Drawing.Size(198, 26);
            this.LineCount.TabIndex = 7;
            // 
            // Lab2_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LineCount);
            this.Controls.Add(this.WordsCount);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.CharacterCount);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.DocFile);
            this.Controls.Add(this.BangNoiDung);
            this.Name = "Lab2_Bai2";
            this.Text = "Lab2_Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}