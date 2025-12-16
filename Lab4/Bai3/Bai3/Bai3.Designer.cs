namespace Bai3
{
    partial class Bai3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Load = new Button();
            txtUrl = new TextBox();
            Reload = new Button();
            DownFiles = new Button();
            DownResources = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(-2, 109);
            webView21.Name = "webView21";
            webView21.Size = new Size(1299, 579);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
            // 
            // Load
            // 
            Load.Location = new Point(34, 12);
            Load.Name = "Load";
            Load.Size = new Size(153, 38);
            Load.TabIndex = 1;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(193, 16);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(934, 31);
            txtUrl.TabIndex = 2;
            // 
            // Reload
            // 
            Reload.Location = new Point(1145, 9);
            Reload.Name = "Reload";
            Reload.Size = new Size(128, 38);
            Reload.TabIndex = 4;
            Reload.Text = "Reload";
            Reload.UseVisualStyleBackColor = true;
            Reload.Click += Reload_Click;
            // 
            // DownFiles
            // 
            DownFiles.Location = new Point(930, 65);
            DownFiles.Name = "DownFiles";
            DownFiles.Size = new Size(128, 38);
            DownFiles.TabIndex = 5;
            DownFiles.Text = "Down Files";
            DownFiles.UseVisualStyleBackColor = true;
            DownFiles.Click += DownFiles_Click;
            // 
            // DownResources
            // 
            DownResources.Location = new Point(1076, 65);
            DownResources.Name = "DownResources";
            DownResources.Size = new Size(208, 38);
            DownResources.TabIndex = 6;
            DownResources.Text = "Down Resources";
            DownResources.UseVisualStyleBackColor = true;
            DownResources.Click += DownResources_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 685);
            Controls.Add(DownResources);
            Controls.Add(DownFiles);
            Controls.Add(Reload);
            Controls.Add(txtUrl);
            Controls.Add(Load);
            Controls.Add(webView21);
            Name = "Bai3";
            Text = "Bài 3";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button Load;
        private TextBox txtUrl;
        private Button Reload;
        private Button DownFiles;
        private Button DownResources;
    }
}
