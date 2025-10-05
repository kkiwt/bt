namespace Lab01
{
    partial class Bai3_NangCao
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
            label1 = new Label();
            SoNguyenNhap = new TextBox();
            Thoat = new Button();
            Xoa = new Button();
            NutTim = new Button();
            label2 = new Label();
            KetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 105);
            label1.Name = "label1";
            label1.Size = new Size(329, 32);
            label1.TabIndex = 1;
            label1.Text = "Nhập Vào Số Nguyên Dương:";
            // 
            // SoNguyenNhap
            // 
            SoNguyenNhap.Location = new Point(422, 108);
            SoNguyenNhap.Name = "SoNguyenNhap";
            SoNguyenNhap.RightToLeft = RightToLeft.No;
            SoNguyenNhap.Size = new Size(251, 31);
            SoNguyenNhap.TabIndex = 2;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(439, 269);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 11;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(267, 271);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(112, 34);
            Xoa.TabIndex = 10;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // NutTim
            // 
            NutTim.Location = new Point(90, 271);
            NutTim.Name = "NutTim";
            NutTim.Size = new Size(112, 34);
            NutTim.TabIndex = 9;
            NutTim.Text = "Tìm";
            NutTim.UseVisualStyleBackColor = true;
            NutTim.Click += NutTim_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 150);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 8;
            label2.Text = "Kết Quả: ";
            // 
            // KetQua
            // 
            KetQua.Location = new Point(208, 153);
            KetQua.Name = "KetQua";
            KetQua.ReadOnly = true;
            KetQua.Size = new Size(465, 31);
            KetQua.TabIndex = 7;
            // 
            // Bai3_NangCao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(NutTim);
            Controls.Add(label2);
            Controls.Add(KetQua);
            Controls.Add(SoNguyenNhap);
            Controls.Add(label1);
            Name = "Bai3_NangCao";
            Text = "Bai3_NangCao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SoNguyenNhap;
        private Button Thoat;
        private Button Xoa;
        private Button NutTim;
        private Label label2;
        private TextBox KetQua;
    }
}