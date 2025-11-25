namespace Bai7
{
    partial class TrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl2 = new TabControl();
            AllTabPage = new TabPage();
            flowPanelAll = new FlowLayoutPanel();
            ToiDongGopTabPage = new TabPage();
            flowPanelMine = new FlowLayoutPanel();
            WelcomeText = new Label();
            label1 = new Label();
            HomNayAn = new Button();
            NutThemMonAn = new Button();
            progressBar1 = new ProgressBar();
            NutLogOut = new Label();
            label2 = new Label();
            label3 = new Label();
            PageCombo = new ComboBox();
            PageSizeCombo = new ComboBox();
            tabControl2.SuspendLayout();
            AllTabPage.SuspendLayout();
            ToiDongGopTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(AllTabPage);
            tabControl2.Controls.Add(ToiDongGopTabPage);
            tabControl2.Location = new Point(2, 131);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(854, 523);
            tabControl2.TabIndex = 1;
            tabControl2.SelectedIndexChanged += tabControl2_SelectedIndexChanged;
            // 
            // AllTabPage
            // 
            AllTabPage.Controls.Add(flowPanelAll);
            AllTabPage.Location = new Point(4, 34);
            AllTabPage.Name = "AllTabPage";
            AllTabPage.Padding = new Padding(3);
            AllTabPage.Size = new Size(846, 485);
            AllTabPage.TabIndex = 0;
            AllTabPage.Text = "All";
            AllTabPage.UseVisualStyleBackColor = true;
            AllTabPage.Click += AllTabPage_Click;
            // 
            // flowPanelAll
            // 
            flowPanelAll.AutoScroll = true;
            flowPanelAll.Dock = DockStyle.Fill;
            flowPanelAll.Location = new Point(3, 3);
            flowPanelAll.Name = "flowPanelAll";
            flowPanelAll.Size = new Size(840, 479);
            flowPanelAll.TabIndex = 0;
            // 
            // ToiDongGopTabPage
            // 
            ToiDongGopTabPage.Controls.Add(flowPanelMine);
            ToiDongGopTabPage.Location = new Point(4, 34);
            ToiDongGopTabPage.Name = "ToiDongGopTabPage";
            ToiDongGopTabPage.Padding = new Padding(3);
            ToiDongGopTabPage.Size = new Size(846, 485);
            ToiDongGopTabPage.TabIndex = 1;
            ToiDongGopTabPage.Text = "Tôi Đóng Góp";
            ToiDongGopTabPage.UseVisualStyleBackColor = true;
            ToiDongGopTabPage.Click += ToiDongGopTabPage_Click;
            // 
            // flowPanelMine
            // 
            flowPanelMine.AutoScroll = true;
            flowPanelMine.Dock = DockStyle.Fill;
            flowPanelMine.Location = new Point(3, 3);
            flowPanelMine.Name = "flowPanelMine";
            flowPanelMine.Size = new Size(840, 479);
            flowPanelMine.TabIndex = 1;
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.Location = new Point(9, 695);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(85, 25);
            WelcomeText.TabIndex = 3;
            WelcomeText.Text = "Welcome";
            WelcomeText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(392, 65);
            label1.TabIndex = 4;
            label1.Text = "Hôm Nay Ăn Gì";
            // 
            // HomNayAn
            // 
            HomNayAn.BackColor = Color.PapayaWhip;
            HomNayAn.Location = new Point(431, 27);
            HomNayAn.Name = "HomNayAn";
            HomNayAn.Size = new Size(178, 59);
            HomNayAn.TabIndex = 5;
            HomNayAn.Text = "Hôm Nay Ăn";
            HomNayAn.UseVisualStyleBackColor = false;
            HomNayAn.Click += HomNayAn_Click;
            // 
            // NutThemMonAn
            // 
            NutThemMonAn.BackColor = SystemColors.Info;
            NutThemMonAn.Location = new Point(650, 27);
            NutThemMonAn.Name = "NutThemMonAn";
            NutThemMonAn.Size = new Size(178, 59);
            NutThemMonAn.TabIndex = 6;
            NutThemMonAn.Text = "Thêm Món Ăn";
            NutThemMonAn.UseVisualStyleBackColor = false;
            NutThemMonAn.Click += NutThemMonAn_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(273, 685);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(218, 35);
            progressBar1.TabIndex = 7;
            // 
            // NutLogOut
            // 
            NutLogOut.AutoSize = true;
            NutLogOut.ForeColor = SystemColors.HotTrack;
            NutLogOut.Location = new Point(174, 695);
            NutLogOut.Name = "NutLogOut";
            NutLogOut.Size = new Size(77, 25);
            NutLogOut.TabIndex = 8;
            NutLogOut.Text = "Log Out";
            NutLogOut.Click += NutLogOut_Click;
            NutLogOut.MouseEnter += NutLogOut_MouseEnter;
            NutLogOut.MouseLeave += NutLogOut_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 690);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 9;
            label2.Text = "Page";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 690);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 10;
            label3.Text = "Page Size";
            // 
            // PageCombo
            // 
            PageCombo.FormattingEnabled = true;
            PageCombo.Location = new Point(563, 687);
            PageCombo.Name = "PageCombo";
            PageCombo.Size = new Size(86, 33);
            PageCombo.TabIndex = 11;
            PageCombo.SelectedIndexChanged += PageCombo_SelectedIndexChanged;
            // 
            // PageSizeCombo
            // 
            PageSizeCombo.FormattingEnabled = true;
            PageSizeCombo.Location = new Point(742, 687);
            PageSizeCombo.Name = "PageSizeCombo";
            PageSizeCombo.Size = new Size(86, 33);
            PageSizeCombo.TabIndex = 12;
            PageSizeCombo.SelectedIndexChanged += PageSizeCombo_SelectedIndexChanged;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(840, 738);
            Controls.Add(PageSizeCombo);
            Controls.Add(PageCombo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NutLogOut);
            Controls.Add(progressBar1);
            Controls.Add(NutThemMonAn);
            Controls.Add(HomNayAn);
            Controls.Add(label1);
            Controls.Add(WelcomeText);
            Controls.Add(tabControl2);
            Name = "TrangChu";
            Text = "Trang Chủ";
            Load += TrangChu_Load;
            tabControl2.ResumeLayout(false);
            AllTabPage.ResumeLayout(false);
            ToiDongGopTabPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl2;
        private TabPage AllTabPage;
        private TabPage ToiDongGopTabPage;
        private Label WelcomeText;
        private Label label1;
        private Button HomNayAn;
        private Button NutThemMonAn;
        private ProgressBar progressBar1;
        private Label NutLogOut;
        private Label label2;
        private Label label3;
        private ComboBox PageCombo;
        private ComboBox PageSizeCombo;
        private FlowLayoutPanel flowPanelAll;
        private FlowLayoutPanel flowPanelMine;
    }
}
