namespace _3B
{
    partial class confirmOrderControl
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
            this.bookTitleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.quantityPriceLbl = new System.Windows.Forms.Label();
            this.byLabel = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.AutoSize = true;
            this.bookTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLbl.Location = new System.Drawing.Point(12, 9);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(138, 20);
            this.bookTitleLbl.TabIndex = 0;
            this.bookTitleLbl.Text = "Book Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "By: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price: ";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(490, 29);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(62, 18);
            this.quantityLbl.TabIndex = 3;
            this.quantityLbl.Text = "Quantity";
            // 
            // quantityPriceLbl
            // 
            this.quantityPriceLbl.AutoSize = true;
            this.quantityPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityPriceLbl.Location = new System.Drawing.Point(649, 29);
            this.quantityPriceLbl.Name = "quantityPriceLbl";
            this.quantityPriceLbl.Size = new System.Drawing.Size(42, 18);
            this.quantityPriceLbl.TabIndex = 4;
            this.quantityPriceLbl.Text = "Price";
            // 
            // byLabel
            // 
            this.byLabel.AutoSize = true;
            this.byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byLabel.Location = new System.Drawing.Point(56, 29);
            this.byLabel.Name = "byLabel";
            this.byLabel.Size = new System.Drawing.Size(72, 20);
            this.byLabel.TabIndex = 5;
            this.byLabel.Text = "by Label";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(64, 48);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(94, 20);
            this.priceLbl.TabIndex = 6;
            this.priceLbl.Text = "Price Label";
            // 
            // confirmOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.byLabel);
            this.Controls.Add(this.quantityPriceLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookTitleLbl);
            this.Name = "confirmOrderControl";
            this.Size = new System.Drawing.Size(746, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label byLabel;
        public System.Windows.Forms.Label bookTitleLbl;
        public System.Windows.Forms.Label quantityLbl;
        public System.Windows.Forms.Label quantityPriceLbl;
        public System.Windows.Forms.Label priceLbl;
    }
}
