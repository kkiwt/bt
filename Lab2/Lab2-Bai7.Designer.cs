namespace Lab02
{
    partial class Lab2_Bai7
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
            openFileDialog1 = new OpenFileDialog();
            treeViewFolders = new TreeView();
            panelContent = new Panel();
            Thoat = new Button();
            SuspendLayout();
            // 
            // treeViewFolders
            // 
            treeViewFolders.Location = new Point(0, 1);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(525, 624);
            treeViewFolders.TabIndex = 0;
            treeViewFolders.AfterSelect += treeViewFolders_AfterSelect;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(601, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(733, 639);
            panelContent.TabIndex = 1;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(65, 639);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(141, 36);
            Thoat.TabIndex = 13;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Lab2_Bai7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1331, 687);
            Controls.Add(Thoat);
            Controls.Add(panelContent);
            Controls.Add(treeViewFolders);
            Name = "Lab2_Bai7";
            Text = "Lab2_Bai7";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TreeView treeViewFolders;
        private Panel panelContent;
        private Button Thoat;
    }
}