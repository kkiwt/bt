namespace Bai7
{
    partial class DanhSachGmail
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
            DanhSachMonAn = new ListView();
            NutQuayLai = new Button();
            NutTai = new Button();
            label1 = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // DanhSachMonAn
            // 
            DanhSachMonAn.FullRowSelect = true;
            DanhSachMonAn.Location = new Point(-2, 115);
            DanhSachMonAn.Name = "DanhSachMonAn";
            DanhSachMonAn.Size = new Size(1031, 338);
            DanhSachMonAn.TabIndex = 0;
            DanhSachMonAn.UseCompatibleStateImageBehavior = false;
            // 
            // NutQuayLai
            // 
            NutQuayLai.Location = new Point(814, 25);
            NutQuayLai.Name = "NutQuayLai";
            NutQuayLai.Size = new Size(178, 67);
            NutQuayLai.TabIndex = 1;
            NutQuayLai.Text = "Quay Lại";
            NutQuayLai.UseVisualStyleBackColor = true;
            NutQuayLai.Click += NutQuayLai_Click;
            // 
            // NutTai
            // 
            NutTai.Location = new Point(570, 25);
            NutTai.Name = "NutTai";
            NutTai.Size = new Size(178, 67);
            NutTai.TabIndex = 2;
            NutTai.Text = "Tải Món Ăn Vào Database";
            NutTai.UseVisualStyleBackColor = true;
            NutTai.Click += NutTai_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 40);
            label1.Name = "label1";
            label1.Size = new Size(524, 32);
            label1.TabIndex = 3;
            label1.Text = "Danh Sách Món Ăn Được Đóng Góp Từ Gmail";
            // 
            // progressBar
            // 
            progressBar.Enabled = false;
            progressBar.Location = new Point(-2, 98);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1031, 26);
            progressBar.TabIndex = 4;
            progressBar.Click += progressBar1_Click;
            // 
            // DanhSachGmail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1023, 450);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(NutTai);
            Controls.Add(NutQuayLai);
            Controls.Add(DanhSachMonAn);
            Name = "DanhSachGmail";
            Text = "Danh Sách Người Đóng Góp Qua Gmail";
            Load += DanhSachGmail_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ListView DanhSachMonAn;
        private Button NutQuayLai;
        private Button NutTai;
        private Label label1;
        private ProgressBar progressBar;
    }
}