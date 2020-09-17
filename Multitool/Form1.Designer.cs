namespace Multitool
{
    partial class Form1
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
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.Credits = new System.Windows.Forms.Label();
            this.Updatelog = new System.Windows.Forms.Button();
            this.Base64Encode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(54, 128);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(210, 13);
            this.GithubLink.TabIndex = 0;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "https://github.com/PY44N/Pyans-Multitool";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(107, 106);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(90, 13);
            this.Credits.TabIndex = 1;
            this.Credits.Text = "Multitool by Pyan ";
            // 
            // Updatelog
            // 
            this.Updatelog.Location = new System.Drawing.Point(74, 80);
            this.Updatelog.Name = "Updatelog";
            this.Updatelog.Size = new System.Drawing.Size(75, 23);
            this.Updatelog.TabIndex = 2;
            this.Updatelog.Text = "Update Log";
            this.Updatelog.UseVisualStyleBackColor = true;
            this.Updatelog.Click += new System.EventHandler(this.Updatelog_Click);
            // 
            // Base64Encode
            // 
            this.Base64Encode.Location = new System.Drawing.Point(10, 6);
            this.Base64Encode.Name = "Base64Encode";
            this.Base64Encode.Size = new System.Drawing.Size(139, 23);
            this.Base64Encode.TabIndex = 3;
            this.Base64Encode.Text = "Base64 Encode";
            this.Base64Encode.UseVisualStyleBackColor = true;
            this.Base64Encode.Click += new System.EventHandler(this.Base64Encode_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Base64 Decode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "IP Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Phone Number Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(154, 80);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(75, 23);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 154);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Base64Encode);
            this.Controls.Add(this.Updatelog);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.GithubLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Button Updatelog;
        private System.Windows.Forms.Button Base64Encode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Settings;
    }
}

