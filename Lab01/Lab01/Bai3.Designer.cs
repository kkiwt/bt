namespace Lab01
{
    partial class Bai3
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
            KetQua = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            NutTim = new Button();
            button2 = new Button();
            Thoat = new Button();
            NangCao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 87);
            label1.Name = "label1";
            label1.Size = new Size(322, 32);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 - 9";
            // 
            // SoNguyenNhap
            // 
            SoNguyenNhap.Location = new Point(472, 90);
            SoNguyenNhap.Name = "SoNguyenNhap";
            SoNguyenNhap.Size = new Size(118, 31);
            SoNguyenNhap.TabIndex = 1;
            SoNguyenNhap.TextChanged += SoNguyenNhap_TextChanged;
            // 
            // KetQua
            // 
            KetQua.Location = new Point(251, 146);
            KetQua.Name = "KetQua";
            KetQua.ReadOnly = true;
            KetQua.Size = new Size(150, 31);
            KetQua.TabIndex = 2;
            KetQua.TextChanged += KetQua_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 143);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 3;
            label2.Text = "Kết Quả: ";
            // 
            // NutTim
            // 
            NutTim.Location = new Point(133, 264);
            NutTim.Name = "NutTim";
            NutTim.Size = new Size(112, 34);
            NutTim.TabIndex = 4;
            NutTim.Text = "Tìm";
            NutTim.UseVisualStyleBackColor = true;
            NutTim.Click += NutTim_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(310, 264);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(482, 262);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 6;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // NangCao
            // 
            NangCao.Location = new Point(669, 374);
            NangCao.Name = "NangCao";
            NangCao.Size = new Size(105, 36);
            NangCao.TabIndex = 7;
            NangCao.Text = "Nâng Cao";
            NangCao.UseVisualStyleBackColor = true;
            NangCao.Click += NangCao_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(NangCao);
            Controls.Add(Thoat);
            Controls.Add(button2);
            Controls.Add(NutTim);
            Controls.Add(label2);
            Controls.Add(KetQua);
            Controls.Add(SoNguyenNhap);
            Controls.Add(label1);
            Name = "Bai3";
            Text = "Form4";
            Load += Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SoNguyenNhap;
        private TextBox KetQua;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Button NutTim;
        private Button button2;
        private Button Thoat;
        private Button NangCao;
    }
}