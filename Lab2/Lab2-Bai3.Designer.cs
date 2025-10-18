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
            this.BangNoiDung = new System.Windows.Forms.RichTextBox();
            this.Doc = new System.Windows.Forms.Button();
            this.Ghi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BangNoiDung
            // 
            this.BangNoiDung.Location = new System.Drawing.Point(436, 61);
            this.BangNoiDung.Name = "BangNoiDung";
            this.BangNoiDung.Size = new System.Drawing.Size(293, 301);
            this.BangNoiDung.TabIndex = 1;
            this.BangNoiDung.Text = "";
            // 
            // Doc
            // 
            this.Doc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Doc.FlatAppearance.BorderSize = 2;
            this.Doc.Location = new System.Drawing.Point(72, 43);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(166, 79);
            this.Doc.TabIndex = 2;
            this.Doc.Text = "button1";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // Ghi
            // 
            this.Ghi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ghi.FlatAppearance.BorderSize = 2;
            this.Ghi.Location = new System.Drawing.Point(72, 177);
            this.Ghi.Name = "Ghi";
            this.Ghi.Size = new System.Drawing.Size(166, 79);
            this.Ghi.TabIndex = 3;
            this.Ghi.Text = "button1";
            this.Ghi.UseVisualStyleBackColor = true;
            this.Ghi.Click += new System.EventHandler(this.Ghi_Click);
            // 
            // Lab2_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ghi);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.BangNoiDung);
            this.Name = "Lab2_Bai3";
            this.Text = "Lab2_Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox BangNoiDung;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Ghi;
    }
}