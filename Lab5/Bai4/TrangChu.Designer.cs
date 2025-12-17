namespace Bai4
{
    partial class TrangChu
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
            this.NutDatVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhSachPhim = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // NutDatVe
            // 
            this.NutDatVe.Location = new System.Drawing.Point(266, 12);
            this.NutDatVe.Name = "NutDatVe";
            this.NutDatVe.Size = new System.Drawing.Size(75, 23);
            this.NutDatVe.TabIndex = 0;
            this.NutDatVe.Text = "Đặt vé";
            this.NutDatVe.UseVisualStyleBackColor = true;
            this.NutDatVe.Click += new System.EventHandler(this.DatVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phim đang chiếu";
            // 
            // DanhSachPhim
            // 
            this.DanhSachPhim.AutoScroll = true;
            this.DanhSachPhim.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DanhSachPhim.Location = new System.Drawing.Point(-6, 42);
            this.DanhSachPhim.Name = "DanhSachPhim";
            this.DanhSachPhim.Size = new System.Drawing.Size(388, 446);
            this.DanhSachPhim.TabIndex = 3;
            this.DanhSachPhim.WrapContents = false;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(382, 487);
            this.Controls.Add(this.DanhSachPhim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NutDatVe);
            this.Name = "TrangChu";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NutDatVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel DanhSachPhim;
    }
}

