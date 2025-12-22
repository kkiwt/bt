namespace Bai4
{
    partial class ChiTietPhim
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.NutQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(-1, 52);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1302, 676);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // NutQuayLai
            // 
            this.NutQuayLai.Location = new System.Drawing.Point(1177, 12);
            this.NutQuayLai.Name = "NutQuayLai";
            this.NutQuayLai.Size = new System.Drawing.Size(116, 34);
            this.NutQuayLai.TabIndex = 1;
            this.NutQuayLai.Text = "Quay lại";
            this.NutQuayLai.UseVisualStyleBackColor = true;
            this.NutQuayLai.Click += new System.EventHandler(this.QuayLai_Click);
            // 
            // ChiTietPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 731);
            this.Controls.Add(this.NutQuayLai);
            this.Controls.Add(this.webView21);
            this.Name = "ChiTietPhim";
            this.Text = "Chi Tiết Phim";
            this.Load += new System.EventHandler(this.ChiTietPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button NutQuayLai;
    }
}