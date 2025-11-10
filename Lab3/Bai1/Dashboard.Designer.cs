namespace Bai1
{
    partial class Dashboard
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
            NutClient = new Button();
            NutServer = new Button();
            SuspendLayout();
            // 
            // NutClient
            // 
            NutClient.Location = new Point(488, 81);
            NutClient.Name = "NutClient";
            NutClient.Size = new Size(141, 64);
            NutClient.TabIndex = 0;
            NutClient.Text = "Client";
            NutClient.UseVisualStyleBackColor = true;
            NutClient.Click += NutClient_Click;
            // 
            // NutServer
            // 
            NutServer.Location = new Point(143, 81);
            NutServer.Name = "NutServer";
            NutServer.Size = new Size(141, 64);
            NutServer.TabIndex = 1;
            NutServer.Text = "Server";
            NutServer.UseVisualStyleBackColor = true;
            NutServer.Click += NutServer_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(770, 227);
            Controls.Add(NutServer);
            Controls.Add(NutClient);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button NutClient;
        private Button NutServer;
    }
}
