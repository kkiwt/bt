namespace Bai7
{
    partial class HomNayAn
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
            panel1 = new Panel();
            AnhThucAn = new PictureBox();
            TenMonAn = new Label();
            DiaChiLabel = new Label();
            GiaLabel = new Label();
            NguoiDongGopLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnhThucAn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(NguoiDongGopLabel);
            panel1.Controls.Add(GiaLabel);
            panel1.Controls.Add(DiaChiLabel);
            panel1.Controls.Add(TenMonAn);
            panel1.Controls.Add(AnhThucAn);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 254);
            panel1.TabIndex = 0;
            // 
            // AnhThucAn
            // 
            AnhThucAn.Location = new Point(-1, 3);
            AnhThucAn.Name = "AnhThucAn";
            AnhThucAn.Size = new Size(220, 251);
            AnhThucAn.TabIndex = 0;
            AnhThucAn.TabStop = false;
            // 
            // TenMonAn
            // 
            TenMonAn.AutoSize = true;
            TenMonAn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenMonAn.Location = new Point(246, 21);
            TenMonAn.Name = "TenMonAn";
            TenMonAn.Size = new Size(99, 38);
            TenMonAn.TabIndex = 1;
            TenMonAn.Text = "label1";
            // 
            // DiaChiLabel
            // 
            DiaChiLabel.AutoSize = true;
            DiaChiLabel.Location = new Point(257, 129);
            DiaChiLabel.Name = "DiaChiLabel";
            DiaChiLabel.Size = new Size(59, 25);
            DiaChiLabel.TabIndex = 2;
            DiaChiLabel.Text = "label1";
            // 
            // GiaLabel
            // 
            GiaLabel.AutoSize = true;
            GiaLabel.Location = new Point(257, 78);
            GiaLabel.Name = "GiaLabel";
            GiaLabel.Size = new Size(59, 25);
            GiaLabel.TabIndex = 3;
            GiaLabel.Text = "label2";
            // 
            // NguoiDongGopLabel
            // 
            NguoiDongGopLabel.AutoSize = true;
            NguoiDongGopLabel.Location = new Point(257, 181);
            NguoiDongGopLabel.Name = "NguoiDongGopLabel";
            NguoiDongGopLabel.Size = new Size(59, 25);
            NguoiDongGopLabel.TabIndex = 4;
            NguoiDongGopLabel.Text = "label3";
            NguoiDongGopLabel.Click += label3_Click;
            // 
            // HomNayAn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 248);
            Controls.Add(panel1);
            Name = "HomNayAn";
            Text = "HomNayAn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnhThucAn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox AnhThucAn;
        private Label TenMonAn;
        private Label NguoiDongGopLabel;
        private Label GiaLabel;
        private Label DiaChiLabel;
    }
}