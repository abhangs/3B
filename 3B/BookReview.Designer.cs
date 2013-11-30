namespace _3B
{
    partial class BookReview
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookLabel = new System.Windows.Forms.Label();
            this.reviewPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reviews For: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.bookLabel);
            this.panel1.Location = new System.Drawing.Point(173, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 56);
            this.panel1.TabIndex = 1;
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookLabel.Location = new System.Drawing.Point(12, 7);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(85, 20);
            this.bookLabel.TabIndex = 0;
            this.bookLabel.Text = "bookLabel";
            // 
            // reviewPanel
            // 
            this.reviewPanel.AutoSize = true;
            this.reviewPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reviewPanel.Location = new System.Drawing.Point(29, 112);
            this.reviewPanel.Name = "reviewPanel";
            this.reviewPanel.Size = new System.Drawing.Size(565, 210);
            this.reviewPanel.TabIndex = 2;
            // 
            // BookReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 392);
            this.Controls.Add(this.reviewPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "BookReview";
            this.Text = "Book Reviews - 3-B.com";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label bookLabel;
        public System.Windows.Forms.Panel reviewPanel;
    }
}