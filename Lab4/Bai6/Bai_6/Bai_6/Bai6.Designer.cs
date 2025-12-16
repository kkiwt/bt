namespace Bai_6
{
    partial class Bai_6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbResult);
            this.panel1.Controls.Add(this.btnGet);
            this.panel1.Controls.Add(this.textBoxToken);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxURL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 332);
            this.panel1.TabIndex = 0;
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(4, 185);
            this.rtbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(738, 143);
            this.rtbResult.TabIndex = 9;
            this.rtbResult.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(606, 52);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(84, 65);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(164, 90);
            this.textBoxToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxToken.Multiline = true;
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(434, 86);
            this.textBoxToken.TabIndex = 7;
            this.textBoxToken.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Token";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(164, 55);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.ReadOnly = true;
            this.textBoxURL.Size = new System.Drawing.Size(434, 26);
            this.textBoxURL.TabIndex = 5;
            this.textBoxURL.TabStop = false;
            this.textBoxURL.Text = "https://nt106.uitiot.vn/auth/token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // Bai_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 364);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai_6";
            this.Text = "Bai_6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label label2;
    }
}

