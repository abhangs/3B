namespace _3B
{
    partial class InsertBookControl_Author
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorFnameTxt = new System.Windows.Forms.TextBox();
            this.authorLnameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // authorFnameTxt
            // 
            this.authorFnameTxt.Location = new System.Drawing.Point(4, 4);
            this.authorFnameTxt.Name = "authorFnameTxt";
            this.authorFnameTxt.Size = new System.Drawing.Size(174, 22);
            this.authorFnameTxt.TabIndex = 0;
            // 
            // authorLnameTxt
            // 
            this.authorLnameTxt.Location = new System.Drawing.Point(184, 4);
            this.authorLnameTxt.Name = "authorLnameTxt";
            this.authorLnameTxt.Size = new System.Drawing.Size(175, 22);
            this.authorLnameTxt.TabIndex = 1;
            // 
            // InsertBookControl_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.authorLnameTxt);
            this.Controls.Add(this.authorFnameTxt);
            this.Name = "InsertBookControl_Author";
            this.Size = new System.Drawing.Size(361, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox authorFnameTxt;
        public System.Windows.Forms.TextBox authorLnameTxt;
    }
}
