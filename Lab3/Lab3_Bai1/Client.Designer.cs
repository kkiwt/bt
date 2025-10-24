namespace Bai1
{
    partial class Client
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
            SoIP = new TextBox();
            BangTinNhan = new RichTextBox();
            SoPort = new TextBox();
            Send = new ReaLTaiizor.Controls.AirButton();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // SoIP
            // 
            SoIP.Location = new Point(159, 45);
            SoIP.Name = "SoIP";
            SoIP.Size = new Size(318, 31);
            SoIP.TabIndex = 0;
            // 
            // BangTinNhan
            // 
            BangTinNhan.Location = new Point(78, 154);
            BangTinNhan.Name = "BangTinNhan";
            BangTinNhan.Size = new Size(501, 236);
            BangTinNhan.TabIndex = 1;
            BangTinNhan.Text = "";
            // 
            // SoPort
            // 
            SoPort.Location = new Point(591, 42);
            SoPort.Name = "SoPort";
            SoPort.Size = new Size(171, 31);
            SoPort.TabIndex = 2;
            // 
            // Send
            // 
            Send.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            Send.Font = new Font("Segoe UI", 9F);
            Send.Image = null;
            Send.Location = new Point(78, 90);
            Send.Name = "Send";
            Send.NoRounding = false;
            Send.Size = new Size(126, 46);
            Send.TabIndex = 5;
            Send.Text = "Send";
            Send.Transparent = false;
            Send.Click += Send_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 48);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 6;
            label1.Text = "IP đích:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 45);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 7;
            label2.Text = "Port đích:";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Send);
            Controls.Add(SoPort);
            Controls.Add(BangTinNhan);
            Controls.Add(SoIP);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SoIP;
        private RichTextBox BangTinNhan;
        private TextBox SoPort;
        private ReaLTaiizor.Controls.AirButton Send;
        private Label label1;
        private Label label2;
    }
}