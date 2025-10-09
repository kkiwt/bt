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
            this.NoiDungFile = new System.Windows.Forms.RichTextBox();
            this.DocFile = new System.Windows.Forms.Button();
            this.GhiFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoiDungFile
            // 
            this.NoiDungFile.Location = new System.Drawing.Point(328, 29);
            this.NoiDungFile.Name = "NoiDungFile";
            this.NoiDungFile.Size = new System.Drawing.Size(460, 385);
            this.NoiDungFile.TabIndex = 0;
            this.NoiDungFile.Text = "";
            // 
            // DocFile
            // 
            this.DocFile.Location = new System.Drawing.Point(38, 75);
            this.DocFile.Name = "DocFile";
            this.DocFile.Size = new System.Drawing.Size(259, 85);
            this.DocFile.TabIndex = 1;
            this.DocFile.Text = "button1";
            this.DocFile.UseVisualStyleBackColor = true;
            this.DocFile.Click += new System.EventHandler(this.DocFile_Click);
            // 
            // GhiFile
            // 
            this.GhiFile.Location = new System.Drawing.Point(38, 272);
            this.GhiFile.Name = "GhiFile";
            this.GhiFile.Size = new System.Drawing.Size(259, 85);
            this.GhiFile.TabIndex = 2;
            this.GhiFile.Text = "button2";
            this.GhiFile.UseVisualStyleBackColor = true;
            this.GhiFile.Click += new System.EventHandler(this.GhiFile_Click);
            // 
            // Lab2_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GhiFile);
            this.Controls.Add(this.DocFile);
            this.Controls.Add(this.NoiDungFile);
            this.Name = "Lab2_Bai1";
            this.Text = "Lab2_Bai1";
            this.Load += new System.EventHandler(this.Lab2_Bai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NoiDungFile;
        private System.Windows.Forms.Button DocFile;
        private System.Windows.Forms.Button GhiFile;
    }
}