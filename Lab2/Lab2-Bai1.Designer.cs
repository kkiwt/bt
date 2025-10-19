namespace Lab02
{
    partial class Lab2_Bai1
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
            NoiDungFile = new RichTextBox();
            DocFile = new Button();
            GhiFile = new Button();
            Thoat = new Button();
            SuspendLayout();
            // 
            // NoiDungFile
            // 
            NoiDungFile.Location = new Point(364, 36);
            NoiDungFile.Margin = new Padding(3, 4, 3, 4);
            NoiDungFile.Name = "NoiDungFile";
            NoiDungFile.ReadOnly = true;
            NoiDungFile.Size = new Size(511, 480);
            NoiDungFile.TabIndex = 0;
            NoiDungFile.Text = "";
            // 
            // DocFile
            // 
            DocFile.Location = new Point(42, 94);
            DocFile.Margin = new Padding(3, 4, 3, 4);
            DocFile.Name = "DocFile";
            DocFile.Size = new Size(288, 106);
            DocFile.TabIndex = 1;
            DocFile.Text = "Đọc File";
            DocFile.UseVisualStyleBackColor = true;
            DocFile.Click += DocFile_Click;
            // 
            // GhiFile
            // 
            GhiFile.Location = new Point(42, 340);
            GhiFile.Margin = new Padding(3, 4, 3, 4);
            GhiFile.Name = "GhiFile";
            GhiFile.Size = new Size(288, 106);
            GhiFile.TabIndex = 2;
            GhiFile.Text = "Ghi File";
            GhiFile.UseVisualStyleBackColor = true;
            GhiFile.Click += GhiFile_Click;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(107, 453);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 13;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Lab2_Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(889, 562);
            Controls.Add(Thoat);
            Controls.Add(GhiFile);
            Controls.Add(DocFile);
            Controls.Add(NoiDungFile);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab2_Bai1";
            Text = "Lab2_Bai1";
            Load += Lab2_Bai1_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NoiDungFile;
        private System.Windows.Forms.Button DocFile;
        private System.Windows.Forms.Button GhiFile;
        private Button Thoat;
    }
}