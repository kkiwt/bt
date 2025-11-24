namespace Bai7
{
    partial class ThemMonAn
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
            NutThemMon = new Button();
            NutClear = new Button();
            label2 = new Label();
            MoTaText = new RichTextBox();
            HinhAnhText = new TextBox();
            DiaChiText = new TextBox();
            GiaText = new TextBox();
            TenMonAnText = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // NutThemMon
            // 
            NutThemMon.Location = new Point(488, 582);
            NutThemMon.Name = "NutThemMon";
            NutThemMon.Size = new Size(143, 46);
            NutThemMon.TabIndex = 0;
            NutThemMon.Text = "Thêm";
            NutThemMon.UseVisualStyleBackColor = true;
            NutThemMon.Click += NutThemMon_Click;
            // 
            // NutClear
            // 
            NutClear.Location = new Point(307, 582);
            NutClear.Name = "NutClear";
            NutClear.Size = new Size(143, 46);
            NutClear.TabIndex = 1;
            NutClear.Text = "Clear";
            NutClear.UseVisualStyleBackColor = true;
            NutClear.Click += NutClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 32);
            label2.Name = "label2";
            label2.Size = new Size(245, 41);
            label2.TabIndex = 3;
            label2.Text = "Hôm Nay Ăn Gì";
            // 
            // MoTaText
            // 
            MoTaText.Location = new Point(126, 344);
            MoTaText.Name = "MoTaText";
            MoTaText.Size = new Size(505, 211);
            MoTaText.TabIndex = 4;
            MoTaText.Text = "";
            // 
            // HinhAnhText
            // 
            HinhAnhText.Location = new Point(126, 231);
            HinhAnhText.Name = "HinhAnhText";
            HinhAnhText.Size = new Size(509, 31);
            HinhAnhText.TabIndex = 5;
            // 
            // DiaChiText
            // 
            DiaChiText.Location = new Point(126, 287);
            DiaChiText.Name = "DiaChiText";
            DiaChiText.Size = new Size(509, 31);
            DiaChiText.TabIndex = 6;
            // 
            // GiaText
            // 
            GiaText.Location = new Point(126, 171);
            GiaText.Name = "GiaText";
            GiaText.Size = new Size(509, 31);
            GiaText.TabIndex = 7;
            // 
            // TenMonAnText
            // 
            TenMonAnText.Location = new Point(126, 107);
            TenMonAnText.Name = "TenMonAnText";
            TenMonAnText.Size = new Size(509, 31);
            TenMonAnText.TabIndex = 8;
            TenMonAnText.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 107);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 9;
            label1.Text = "Tên Món Ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 171);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 10;
            label3.Text = "Giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 231);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 11;
            label4.Text = "Hình Ảnh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 287);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 12;
            label5.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 347);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 13;
            label6.Text = "Mô Tả:";
            // 
            // ThemMonAn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 664);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(TenMonAnText);
            Controls.Add(GiaText);
            Controls.Add(DiaChiText);
            Controls.Add(HinhAnhText);
            Controls.Add(MoTaText);
            Controls.Add(label2);
            Controls.Add(NutClear);
            Controls.Add(NutThemMon);
            Name = "ThemMonAn";
            Text = "ThemMonAn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NutThemMon;
        private Button NutClear;
        private Label label2;
        private RichTextBox MoTaText;
        private TextBox HinhAnhText;
        private TextBox DiaChiText;
        private TextBox GiaText;
        private TextBox TenMonAnText;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}