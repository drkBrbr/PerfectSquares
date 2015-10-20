namespace UnicodeForCSharp
{
    partial class frmUnicode
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
            this.btnShowUnicode = new System.Windows.Forms.Button();
            this.lstUnicode = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowUnicode
            // 
            this.btnShowUnicode.Location = new System.Drawing.Point(59, 12);
            this.btnShowUnicode.Name = "btnShowUnicode";
            this.btnShowUnicode.Size = new System.Drawing.Size(129, 23);
            this.btnShowUnicode.TabIndex = 0;
            this.btnShowUnicode.Text = "Show Unicode";
            this.btnShowUnicode.UseVisualStyleBackColor = true;
            this.btnShowUnicode.Click += new System.EventHandler(this.btnShowUnicode_Click);
            // 
            // lstUnicode
            // 
            this.lstUnicode.FormattingEnabled = true;
            this.lstUnicode.Location = new System.Drawing.Point(59, 41);
            this.lstUnicode.Name = "lstUnicode";
            this.lstUnicode.Size = new System.Drawing.Size(129, 186);
            this.lstUnicode.TabIndex = 1;
            // 
            // frmUnicode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstUnicode);
            this.Controls.Add(this.btnShowUnicode);
            this.Name = "frmUnicode";
            this.Text = "Unicode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowUnicode;
        private System.Windows.Forms.ListBox lstUnicode;
    }
}

