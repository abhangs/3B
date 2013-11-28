namespace _3B
{
    partial class searchResultControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bookLbl = new System.Windows.Forms.Label();
            this.ByLbl = new System.Windows.Forms.Label();
            this.byLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reviews";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bookLbl
            // 
            this.bookLbl.AutoSize = true;
            this.bookLbl.Location = new System.Drawing.Point(150, 13);
            this.bookLbl.Name = "bookLbl";
            this.bookLbl.Size = new System.Drawing.Size(69, 17);
            this.bookLbl.TabIndex = 2;
            this.bookLbl.Text = "booklabel";
            // 
            // ByLbl
            // 
            this.ByLbl.AutoSize = true;
            this.ByLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByLbl.Location = new System.Drawing.Point(150, 39);
            this.ByLbl.Name = "ByLbl";
            this.ByLbl.Size = new System.Drawing.Size(26, 17);
            this.ByLbl.TabIndex = 3;
            this.ByLbl.Text = "By";
            // 
            // byLabel
            // 
            this.byLabel.AutoSize = true;
            this.byLabel.Location = new System.Drawing.Point(182, 39);
            this.byLabel.Name = "byLabel";
            this.byLabel.Size = new System.Drawing.Size(59, 17);
            this.byLabel.TabIndex = 4;
            this.byLabel.Text = "ByLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Publisher: ";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(242, 56);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(102, 17);
            this.publisherLabel.TabIndex = 6;
            this.publisherLabel.Text = "PublisherLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ISBN: ";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(209, 73);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(74, 17);
            this.isbnLabel.TabIndex = 8;
            this.isbnLabel.Text = "ISBNLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price: ";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(392, 71);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(75, 17);
            this.priceLbl.TabIndex = 10;
            this.priceLbl.Text = "PriceLabel";
            // 
            // searchResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.byLabel);
            this.Controls.Add(this.ByLbl);
            this.Controls.Add(this.bookLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "searchResultControl";
            this.Size = new System.Drawing.Size(565, 106);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label bookLbl;
        private System.Windows.Forms.Label ByLbl;
        private System.Windows.Forms.Label byLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceLbl;
    }
}
