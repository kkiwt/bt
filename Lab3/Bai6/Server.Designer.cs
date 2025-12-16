namespace ChatServer
{
    partial class Server
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnListen = new System.Windows.Forms.Button();
            this.flpLog = new System.Windows.Forms.FlowLayoutPanel();
            this.NutTatListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(44, 14);
            this.btnListen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(159, 35);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Start Listening";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // flpLog
            // 
            this.flpLog.Location = new System.Drawing.Point(44, 70);
            this.flpLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpLog.Name = "flpLog";
            this.flpLog.Size = new System.Drawing.Size(483, 261);
            this.flpLog.TabIndex = 3;
            // 
            // NutTatListen
            // 
            this.NutTatListen.Location = new System.Drawing.Point(368, 14);
            this.NutTatListen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NutTatListen.Name = "NutTatListen";
            this.NutTatListen.Size = new System.Drawing.Size(159, 35);
            this.NutTatListen.TabIndex = 4;
            this.NutTatListen.Text = "Stop Listening";
            this.NutTatListen.UseVisualStyleBackColor = true;
            this.NutTatListen.Click += new System.EventHandler(this.NutTatListen_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 355);
            this.Controls.Add(this.NutTatListen);
            this.Controls.Add(this.flpLog);
            this.Controls.Add(this.btnListen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.Text = "Chat Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.FlowLayoutPanel flpLog;
        private System.Windows.Forms.Button NutTatListen;
    }
}
