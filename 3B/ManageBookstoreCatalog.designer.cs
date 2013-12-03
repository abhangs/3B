namespace _3B
{
    partial class ManageBookstoreCatalog
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
            this.insertButton = new System.Windows.Forms.Button();
            this.modifyDeleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(97, 38);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(271, 43);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert New Book";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // modifyDeleteButton
            // 
            this.modifyDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyDeleteButton.Location = new System.Drawing.Point(97, 107);
            this.modifyDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyDeleteButton.Name = "modifyDeleteButton";
            this.modifyDeleteButton.Size = new System.Drawing.Size(271, 43);
            this.modifyDeleteButton.TabIndex = 1;
            this.modifyDeleteButton.Text = "Modify/Delete Book";
            this.modifyDeleteButton.UseVisualStyleBackColor = true;
            this.modifyDeleteButton.Click += new System.EventHandler(this.modifyDeleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(97, 177);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(271, 43);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back to Main Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageBookstoreCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.modifyDeleteButton);
            this.Controls.Add(this.insertButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageBookstoreCatalog";
            this.Text = "Manage Bookstore Catalog 3-B.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageBookstoreCatalog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button modifyDeleteButton;
        private System.Windows.Forms.Button backButton;
    }
}