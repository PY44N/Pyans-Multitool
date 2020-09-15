namespace Multitool
{
    partial class IPInfo
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
            this.IP = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(12, 16);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(307, 20);
            this.IP.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(118, 43);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(12, 72);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(307, 99);
            this.Out.TabIndex = 2;
            this.Out.Text = "";
            // 
            // IPInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 182);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IPInfo";
            this.Text = "IPInfo";
            this.Load += new System.EventHandler(this.IPInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox Out;
    }
}