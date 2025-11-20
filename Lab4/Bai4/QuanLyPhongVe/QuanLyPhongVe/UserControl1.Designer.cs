namespace CinemaManagement
{
    partial class UserControl1
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
            TenPhim1 = new Label();
            DatVePhim1 = new Button();
            ChiTietPhim1 = new Button();
            PosterPhim1 = new PictureBox();
            Phim1 = new MetroFramework.Controls.MetroUserControl();
            ((System.ComponentModel.ISupportInitialize)PosterPhim1).BeginInit();
            SuspendLayout();
            // 
            // TenPhim1
            // 
            TenPhim1.AutoSize = true;
            TenPhim1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenPhim1.ForeColor = SystemColors.Menu;
            TenPhim1.Location = new Point(98, 273);
            TenPhim1.Name = "TenPhim1";
            TenPhim1.Size = new Size(49, 26);
            TenPhim1.TabIndex = 27;
            TenPhim1.Text = "MAI";
            // 
            // DatVePhim1
            // 
            DatVePhim1.BackColor = Color.FromArgb(230, 57, 70);
            DatVePhim1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatVePhim1.ForeColor = SystemColors.Control;
            DatVePhim1.Location = new Point(143, 300);
            DatVePhim1.Margin = new Padding(3, 2, 3, 2);
            DatVePhim1.Name = "DatVePhim1";
            DatVePhim1.Size = new Size(94, 33);
            DatVePhim1.TabIndex = 26;
            DatVePhim1.Text = "ĐẶT VÉ";
            DatVePhim1.UseCompatibleTextRendering = true;
            DatVePhim1.UseVisualStyleBackColor = false;
            // 
            // ChiTietPhim1
            // 
            ChiTietPhim1.BackColor = Color.Pink;
            ChiTietPhim1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChiTietPhim1.ForeColor = Color.Maroon;
            ChiTietPhim1.Location = new Point(15, 300);
            ChiTietPhim1.Margin = new Padding(3, 2, 3, 2);
            ChiTietPhim1.Name = "ChiTietPhim1";
            ChiTietPhim1.Size = new Size(94, 32);
            ChiTietPhim1.TabIndex = 25;
            ChiTietPhim1.Text = "CHI TIẾT";
            ChiTietPhim1.UseVisualStyleBackColor = false;
            // 
            // PosterPhim1
            // 
            PosterPhim1.Location = new Point(0, 0);
            PosterPhim1.Margin = new Padding(3, 2, 3, 2);
            PosterPhim1.Name = "PosterPhim1";
            PosterPhim1.Size = new Size(259, 263);
            PosterPhim1.SizeMode = PictureBoxSizeMode.Zoom;
            PosterPhim1.TabIndex = 24;
            PosterPhim1.TabStop = false;
            PosterPhim1.Click += PosterPhim1_Click;
            // 
            // Phim1
            // 
            Phim1.BackColor = SystemColors.ControlLightLight;
            Phim1.CustomBackground = false;
            Phim1.Location = new Point(-1, 0);
            Phim1.Margin = new Padding(3, 2, 3, 2);
            Phim1.Name = "Phim1";
            Phim1.Size = new Size(261, 332);
            Phim1.Style = MetroFramework.MetroColorStyle.Magenta;
            Phim1.StyleManager = null;
            Phim1.TabIndex = 23;
            Phim1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(TenPhim1);
            Controls.Add(DatVePhim1);
            Controls.Add(ChiTietPhim1);
            Controls.Add(PosterPhim1);
            Controls.Add(Phim1);
            Name = "UserControl1";
            Size = new Size(262, 332);
            ((System.ComponentModel.ISupportInitialize)PosterPhim1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TenPhim1;
        private Button DatVePhim1;
        private Button ChiTietPhim1;
        private PictureBox PosterPhim1;
        private MetroFramework.Controls.MetroUserControl Phim1;
    }
}
