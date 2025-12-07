namespace Bai06
{
    partial class Mail_detail
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
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.txt_Mail_Content = new System.Windows.Forms.WebBrowser();
            this.lb_From = new System.Windows.Forms.Label();
            this.lb_To = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_From
            // 
            this.txt_From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_From.Location = new System.Drawing.Point(106, 27);
            this.txt_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_From.Name = "txt_From";
            this.txt_From.ReadOnly = true;
            this.txt_From.Size = new System.Drawing.Size(762, 30);
            this.txt_From.TabIndex = 1;
            // 
            // txt_To
            // 
            this.txt_To.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_To.Location = new System.Drawing.Point(106, 72);
            this.txt_To.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_To.Name = "txt_To";
            this.txt_To.ReadOnly = true;
            this.txt_To.Size = new System.Drawing.Size(762, 30);
            this.txt_To.TabIndex = 3;
            // 
            // txt_Subject
            // 
            this.txt_Subject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.Location = new System.Drawing.Point(9, 126);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.ReadOnly = true;
            this.txt_Subject.Size = new System.Drawing.Size(859, 30);
            this.txt_Subject.TabIndex = 4;
            // 
            // txt_Mail_Content
            // 
            this.txt_Mail_Content.Location = new System.Drawing.Point(12, 183);
            this.txt_Mail_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Mail_Content.MinimumSize = new System.Drawing.Size(18, 16);
            this.txt_Mail_Content.Name = "txt_Mail_Content";
            this.txt_Mail_Content.Size = new System.Drawing.Size(856, 445);
            this.txt_Mail_Content.TabIndex = 5;
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_From.Location = new System.Drawing.Point(22, 30);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(57, 23);
            this.lb_From.TabIndex = 6;
            this.lb_From.Text = "From";
            // 
            // lb_To
            // 
            this.lb_To.AutoSize = true;
            this.lb_To.Font = new System.Drawing.Font("Arial   ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_To.Location = new System.Drawing.Point(22, 75);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(33, 23);
            this.lb_To.TabIndex = 8;
            this.lb_To.Text = "To";
            // 
            // Mail_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 656);
            this.Controls.Add(this.lb_To);
            this.Controls.Add(this.lb_From);
            this.Controls.Add(this.txt_Mail_Content);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_From);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mail_detail";
            this.Load += new System.EventHandler(this.Mail_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.WebBrowser txt_Mail_Content;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.Label lb_To;
    }
}