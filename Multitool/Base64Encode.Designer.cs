namespace Multitool
{
    partial class Base64Encode
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
            this.ToEncode = new System.Windows.Forms.RichTextBox();
            this.Encode = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ToEncode
            // 
            this.ToEncode.Location = new System.Drawing.Point(12, 12);
            this.ToEncode.Name = "ToEncode";
            this.ToEncode.Size = new System.Drawing.Size(371, 86);
            this.ToEncode.TabIndex = 0;
            this.ToEncode.Text = "";
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(127, 233);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(142, 32);
            this.Encode.TabIndex = 1;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(12, 122);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(371, 91);
            this.Out.TabIndex = 2;
            this.Out.Text = "";
            // 
            // Base64Encode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 277);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.ToEncode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Base64Encode";
            this.Text = "Base64Encode";
            this.Load += new System.EventHandler(this.Base64Encode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ToEncode;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.RichTextBox Out;
    }
}