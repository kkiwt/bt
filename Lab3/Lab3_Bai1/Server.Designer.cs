namespace Bai1
{
    partial class Server
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
            SoPortListen = new TextBox();
            NutListen = new ReaLTaiizor.Controls.AirButton();
            ListListen = new ReaLTaiizor.Controls.MaterialListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // SoPortListen
            // 
            SoPortListen.Location = new Point(408, 66);
            SoPortListen.Name = "SoPortListen";
            SoPortListen.Size = new Size(171, 31);
            SoPortListen.TabIndex = 3;
            // 
            // NutListen
            // 
            NutListen.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            NutListen.Font = new Font("Segoe UI", 9F);
            NutListen.Image = null;
            NutListen.Location = new Point(628, 51);
            NutListen.Name = "NutListen";
            NutListen.NoRounding = false;
            NutListen.Size = new Size(126, 46);
            NutListen.TabIndex = 4;
            NutListen.Text = "Listen";
            NutListen.Transparent = false;
            NutListen.Click += NutListen_Click;
            // 
            // ListListen
            // 
            ListListen.AutoSizeTable = false;
            ListListen.BackColor = Color.FromArgb(255, 255, 255);
            ListListen.BorderStyle = BorderStyle.None;
            ListListen.Depth = 0;
            ListListen.FullRowSelect = true;
            ListListen.Location = new Point(91, 117);
            ListListen.MinimumSize = new Size(200, 100);
            ListListen.MouseLocation = new Point(-1, -1);
            ListListen.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ListListen.Name = "ListListen";
            ListListen.OwnerDraw = true;
            ListListen.Size = new Size(488, 285);
            ListListen.TabIndex = 5;
            ListListen.UseCompatibleStateImageBehavior = false;
            ListListen.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 69);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 6;
            label1.Text = "Số Port Lắng Nghe:";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ListListen);
            Controls.Add(NutListen);
            Controls.Add(SoPortListen);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SoPortListen;
        private ReaLTaiizor.Controls.AirButton NutListen;
        private ReaLTaiizor.Controls.MaterialListView ListListen;
        private Label label1;
    }
}