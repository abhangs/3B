namespace _3B
{
    partial class SearchForm
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
            this.searchForLbl = new System.Windows.Forms.Label();
            this.searchInLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.categoryCmbBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.manageShpngCartBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchInLstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchForLbl
            // 
            this.searchForLbl.AutoSize = true;
            this.searchForLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForLbl.Location = new System.Drawing.Point(28, 39);
            this.searchForLbl.Name = "searchForLbl";
            this.searchForLbl.Size = new System.Drawing.Size(109, 20);
            this.searchForLbl.TabIndex = 0;
            this.searchForLbl.Text = "Search for: ";
            // 
            // searchInLbl
            // 
            this.searchInLbl.AutoSize = true;
            this.searchInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInLbl.Location = new System.Drawing.Point(28, 130);
            this.searchInLbl.Name = "searchInLbl";
            this.searchInLbl.Size = new System.Drawing.Size(101, 20);
            this.searchInLbl.TabIndex = 1;
            this.searchInLbl.Text = "Search In: ";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(28, 230);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(96, 20);
            this.categoryLbl.TabIndex = 2;
            this.categoryLbl.Text = "Category: ";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(143, 36);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(325, 27);
            this.searchTxtBox.TabIndex = 3;
            // 
            // categoryCmbBox
            // 
            this.categoryCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCmbBox.FormattingEnabled = true;
            this.categoryCmbBox.Location = new System.Drawing.Point(143, 227);
            this.categoryCmbBox.Name = "categoryCmbBox";
            this.categoryCmbBox.Size = new System.Drawing.Size(196, 28);
            this.categoryCmbBox.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(536, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(231, 35);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // manageShpngCartBtn
            // 
            this.manageShpngCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageShpngCartBtn.Location = new System.Drawing.Point(536, 122);
            this.manageShpngCartBtn.Name = "manageShpngCartBtn";
            this.manageShpngCartBtn.Size = new System.Drawing.Size(231, 37);
            this.manageShpngCartBtn.TabIndex = 7;
            this.manageShpngCartBtn.Text = "Manage Shopping Cart";
            this.manageShpngCartBtn.UseVisualStyleBackColor = true;
            this.manageShpngCartBtn.Click += new System.EventHandler(this.manageShpngCartBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(536, 218);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(231, 37);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "EXIT 3-B.com";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchInLstBox
            // 
            this.searchInLstBox.FormattingEnabled = true;
            this.searchInLstBox.ItemHeight = 16;
            this.searchInLstBox.Location = new System.Drawing.Point(143, 94);
            this.searchInLstBox.Name = "searchInLstBox";
            this.searchInLstBox.Size = new System.Drawing.Size(325, 116);
            this.searchInLstBox.TabIndex = 9;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 300);
            this.Controls.Add(this.searchInLstBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.manageShpngCartBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.categoryCmbBox);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.searchInLbl);
            this.Controls.Add(this.searchForLbl);
            this.Name = "SearchForm";
            this.Text = "SEARCH -3-B.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchForLbl;
        private System.Windows.Forms.Label searchInLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.ComboBox categoryCmbBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button manageShpngCartBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ListBox searchInLstBox;
    }
}