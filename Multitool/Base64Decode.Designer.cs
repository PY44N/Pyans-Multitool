namespace Multitool
{
    partial class Base64Decode
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
            this.ToDecode = new System.Windows.Forms.RichTextBox();
            this.Out = new System.Windows.Forms.RichTextBox();
            this.Decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToDecode
            // 
            this.ToDecode.Location = new System.Drawing.Point(12, 12);
            this.ToDecode.Name = "ToDecode";
            this.ToDecode.Size = new System.Drawing.Size(371, 86);
            this.ToDecode.TabIndex = 0;
            this.ToDecode.Text = "";
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(12, 122);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(371, 91);
            this.Out.TabIndex = 1;
            this.Out.Text = "";
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(127, 233);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(142, 32);
            this.Decode.TabIndex = 2;
            this.Decode.Text = "Decode";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Base64Decode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 277);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.ToDecode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Base64Decode";
            this.Text = "Base64Decode";
            this.Load += new System.EventHandler(this.Base64Decode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ToDecode;
        private System.Windows.Forms.RichTextBox Out;
        private System.Windows.Forms.Button Decode;
    }
}