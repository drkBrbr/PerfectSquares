namespace UnicodeCSharp
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
            this.btnCalcualteUnicode = new System.Windows.Forms.Button();
            this.lstUnicode = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalcualteUnicode
            // 
            this.btnCalcualteUnicode.Location = new System.Drawing.Point(83, 45);
            this.btnCalcualteUnicode.Name = "btnCalcualteUnicode";
            this.btnCalcualteUnicode.Size = new System.Drawing.Size(107, 23);
            this.btnCalcualteUnicode.TabIndex = 0;
            this.btnCalcualteUnicode.Text = "Calculate Unicode";
            this.btnCalcualteUnicode.UseVisualStyleBackColor = true;
            this.btnCalcualteUnicode.Click += new System.EventHandler(this.btnCalcualteUnicode_Click);
            // 
            // lstUnicode
            // 
            this.lstUnicode.FormattingEnabled = true;
            this.lstUnicode.Location = new System.Drawing.Point(83, 125);
            this.lstUnicode.Name = "lstUnicode";
            this.lstUnicode.Size = new System.Drawing.Size(120, 95);
            this.lstUnicode.TabIndex = 1;
            // 
            // frmUnicode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstUnicode);
            this.Controls.Add(this.btnCalcualteUnicode);
            this.Name = "frmUnicode";
            this.Text = "Unicode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcualteUnicode;
        private System.Windows.Forms.ListBox lstUnicode;
    }
}

