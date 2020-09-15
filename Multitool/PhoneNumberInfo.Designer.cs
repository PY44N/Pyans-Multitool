namespace Multitool
{
    partial class PhoneNumberInfo
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
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.RichTextBox();
            this.Information = new System.Windows.Forms.Label();
            this.Example = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(13, 42);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(370, 20);
            this.PhoneNumber.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(143, 68);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(94, 27);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(13, 101);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(370, 51);
            this.Out.TabIndex = 2;
            this.Out.Text = "";
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Location = new System.Drawing.Point(73, 9);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(213, 13);
            this.Information.TabIndex = 3;
            this.Information.Text = "Please include area code and country code";
            // 
            // Example
            // 
            this.Example.AutoSize = true;
            this.Example.Location = new System.Drawing.Point(150, 26);
            this.Example.Name = "Example";
            this.Example.Size = new System.Drawing.Size(87, 13);
            this.Example.TabIndex = 4;
            this.Example.Text = "ex 11231234567";
            // 
            // PhoneNumberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 161);
            this.Controls.Add(this.Example);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.PhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhoneNumberInfo";
            this.Text = "PhoneNumberInfo";
            this.Load += new System.EventHandler(this.PhoneNumberInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox Out;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label Example;
    }
}