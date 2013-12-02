namespace _3B
{
    partial class ModifyDeleteBookControl
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.bookLbl = new System.Windows.Forms.Label();
            this.ByLbl = new System.Windows.Forms.Label();
            this.byLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.deletedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(18, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 37);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(18, 56);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(110, 36);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button2_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price: ";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(210, 65);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(75, 17);
            this.priceLbl.TabIndex = 10;
            this.priceLbl.Text = "PriceLabel";
            // 
            // deletedLbl
            // 
            this.deletedLbl.AutoSize = true;
            this.deletedLbl.BackColor = System.Drawing.Color.Red;
            this.deletedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deletedLbl.Location = new System.Drawing.Point(435, 63);
            this.deletedLbl.Name = "deletedLbl";
            this.deletedLbl.Size = new System.Drawing.Size(95, 20);
            this.deletedLbl.TabIndex = 11;
            this.deletedLbl.Text = "DELETED";
            this.deletedLbl.Visible = false;
            // 
            // ModifyDeleteBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deletedLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.byLabel);
            this.Controls.Add(this.ByLbl);
            this.Controls.Add(this.bookLbl);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Name = "ModifyDeleteBookControl";
            this.Size = new System.Drawing.Size(565, 106);
            this.Load += new System.EventHandler(this.searchResultControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ByLbl;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label byLabel;
        public System.Windows.Forms.Label bookLbl;
        public System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button updateBtn;
        public System.Windows.Forms.Label deletedLbl;
        public System.Windows.Forms.Button deleteBtn;
    }
}
