namespace Lab01
{
    partial class Bai5
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
            B = new TextBox();
            A = new TextBox();
            KetQua = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            Thoat = new Button();
            SuspendLayout();
            // 
            // B
            // 
            B.Location = new Point(274, 115);
            B.Name = "B";
            B.Size = new Size(192, 31);
            B.TabIndex = 3;
            // 
            // A
            // 
            A.Location = new Point(274, 62);
            A.Name = "A";
            A.Size = new Size(192, 31);
            A.TabIndex = 2;
            // 
            // KetQua
            // 
            KetQua.Location = new Point(60, 205);
            KetQua.Multiline = true;
            KetQua.Name = "KetQua";
            KetQua.ReadOnly = true;
            KetQua.Size = new Size(683, 381);
            KetQua.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 172);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 5;
            label1.Text = "Kết Quả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(501, 61);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 6;
            label2.Text = "Chọn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 116);
            label3.Name = "label3";
            label3.Size = new Size(213, 30);
            label3.TabIndex = 7;
            label3.Text = "Nhập Số Nguyên B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 61);
            label4.Name = "label4";
            label4.Size = new Size(214, 30);
            label4.TabIndex = 8;
            label4.Text = "Nhập Số Nguyên A:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng Cửu Chương (B - A)", "(A-B)!", "S = A mũ 1 + A mũ 2 +...+ A mũ B" });
            comboBox1.Location = new Point(571, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 33);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(571, 116);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 12;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 612);
            Controls.Add(Thoat);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KetQua);
            Controls.Add(B);
            Controls.Add(A);
            Name = "Bai5";
            Text = "Bai5";
            Load += Bai5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox B;
        private TextBox A;
        private TextBox KetQua;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button Thoat;
    }
}