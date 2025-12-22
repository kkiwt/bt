namespace Bai4
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
            Server = new Button();
            SuspendLayout();
            // 
            // NutClient
            // 
            NutClient.Location = new Point(122, 89);
            NutClient.Margin = new Padding(2);
            NutClient.Name = "NutClient";
            NutClient.Size = new Size(191, 44);
            NutClient.TabIndex = 0;
            NutClient.Text = "Client";
            NutClient.UseVisualStyleBackColor = true;
            NutClient.Click += NutClient_Click;
            // 
            // Server
            // 
            Server.Location = new Point(464, 92);
            Server.Margin = new Padding(2);
            Server.Name = "Server";
            Server.Size = new Size(214, 41);
            Server.TabIndex = 1;
            Server.Text = "Server";
            Server.UseVisualStyleBackColor = true;
            Server.Click += Server_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 212);
            Controls.Add(Server);
            Controls.Add(NutClient);
            Margin = new Padding(2);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button NutClient;
        private Button Server;
    }
}
