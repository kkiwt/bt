namespace ChatClient
{
    partial class Dashboard
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
            this.NutClient = new System.Windows.Forms.Button();
            this.Server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NutClient
            // 
            this.NutClient.Location = new System.Drawing.Point(104, 85);
            this.NutClient.Name = "NutClient";
            this.NutClient.Size = new System.Drawing.Size(236, 70);
            this.NutClient.TabIndex = 0;
            this.NutClient.Text = "Client";
            this.NutClient.UseVisualStyleBackColor = true;
            this.NutClient.Click += new System.EventHandler(this.NutClient_Click);
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(483, 85);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(236, 70);
            this.Server.TabIndex = 1;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = true;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.NutClient);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NutClient;
        private System.Windows.Forms.Button Server;
    }
}