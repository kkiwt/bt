namespace Lab01
{
    partial class Bai8
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
            MonAnVao = new TextBox();
            label1 = new Label();
            KetQua = new TextBox();
            label2 = new Label();
            Thoat = new Button();
            Tim = new Button();
            Xoa = new Button();
            Them = new Button();
            BangThucAn = new ListBox();
            SuspendLayout();
            // 
            // MonAnVao
            // 
            MonAnVao.Location = new Point(61, 75);
            MonAnVao.Name = "MonAnVao";
            MonAnVao.Size = new Size(308, 31);
            MonAnVao.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 41);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 2;
            label1.Text = "Nhập Món Ăn:";
            // 
            // KetQua
            // 
            KetQua.Location = new Point(259, 391);
            KetQua.Name = "KetQua";
            KetQua.ReadOnly = true;
            KetQua.Size = new Size(560, 31);
            KetQua.TabIndex = 3;
            KetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 394);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 4;
            label2.Text = "Món Ăn Buổi Này Là:";
            // 
            // Thoat
            // 
            Thoat.Location = new Point(61, 303);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 12;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Tim
            // 
            Tim.Location = new Point(61, 242);
            Tim.Name = "Tim";
            Tim.Size = new Size(141, 36);
            Tim.TabIndex = 13;
            Tim.Text = "Tìm Món Ăn";
            Tim.UseVisualStyleBackColor = true;
            Tim.Click += Tim_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(61, 179);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(141, 36);
            Xoa.TabIndex = 14;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Them
            // 
            Them.Location = new Point(61, 120);
            Them.Name = "Them";
            Them.Size = new Size(141, 36);
            Them.TabIndex = 15;
            Them.Text = "Thêm";
            Them.UseVisualStyleBackColor = true;
            Them.Click += Them_Click;
            // 
            // BangThucAn
            // 
            BangThucAn.FormattingEnabled = true;
            BangThucAn.ItemHeight = 25;
            BangThucAn.Location = new Point(425, 58);
            BangThucAn.Name = "BangThucAn";
            BangThucAn.Size = new Size(394, 304);
            BangThucAn.TabIndex = 16;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(860, 464);
            Controls.Add(BangThucAn);
            Controls.Add(Them);
            Controls.Add(Xoa);
            Controls.Add(Tim);
            Controls.Add(Thoat);
            Controls.Add(label2);
            Controls.Add(KetQua);
            Controls.Add(label1);
            Controls.Add(MonAnVao);
            Name = "Bai8";
            Text = "Bai8";
            Load += Bai8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox MonAnVao;
        private Label label1;
        private TextBox KetQua;
        private Label label2;
        private Button Thoat;
        private Button Tim;
        private Button Xoa;
        private Button Them;
        private ListBox BangThucAn;
    }
}