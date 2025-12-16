namespace Bai7
{
    partial class MonAn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDelete = new Button();
            NguoiDongGopLabel = new Label();
            GiaLabel = new Label();
            DiaChiLabel = new Label();
            TenMonAn = new Label();
            AnhThucAn = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnhThucAn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(NguoiDongGopLabel);
            panel1.Controls.Add(GiaLabel);
            panel1.Controls.Add(DiaChiLabel);
            panel1.Controls.Add(TenMonAn);
            panel1.Controls.Add(AnhThucAn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 254);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(681, 45);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 58);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // NguoiDongGopLabel
            // 
            NguoiDongGopLabel.AutoSize = true;
            NguoiDongGopLabel.Location = new Point(257, 181);
            NguoiDongGopLabel.Name = "NguoiDongGopLabel";
            NguoiDongGopLabel.Size = new Size(59, 25);
            NguoiDongGopLabel.TabIndex = 4;
            NguoiDongGopLabel.Text = "label3";
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
            // DiaChiLabel
            // 
            DiaChiLabel.AutoSize = true;
            DiaChiLabel.Location = new Point(257, 129);
            DiaChiLabel.Name = "DiaChiLabel";
            DiaChiLabel.Size = new Size(59, 25);
            DiaChiLabel.TabIndex = 2;
            DiaChiLabel.Text = "label1";
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
            // AnhThucAn
            // 
            AnhThucAn.Location = new Point(-1, 3);
            AnhThucAn.Name = "AnhThucAn";
            AnhThucAn.Size = new Size(220, 251);
            AnhThucAn.TabIndex = 0;
            AnhThucAn.TabStop = false;
            // 
            // MonAn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MonAn";
            Size = new Size(840, 254);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnhThucAn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label NguoiDongGopLabel;
        private Label GiaLabel;
        private Label DiaChiLabel;
        private Label TenMonAn;
        private PictureBox AnhThucAn;
        private Button btnDelete;
    }
}
