namespace _3B
{
    partial class AdminHome
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
            this.manageBookCatalogButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.systemMaintButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageBookCatalogButton
            // 
            this.manageBookCatalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBookCatalogButton.Location = new System.Drawing.Point(65, 47);
            this.manageBookCatalogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageBookCatalogButton.Name = "manageBookCatalogButton";
            this.manageBookCatalogButton.Size = new System.Drawing.Size(303, 43);
            this.manageBookCatalogButton.TabIndex = 0;
            this.manageBookCatalogButton.Text = "Manage Bookstore Catalog";
            this.manageBookCatalogButton.UseVisualStyleBackColor = true;
            this.manageBookCatalogButton.Click += new System.EventHandler(this.manageBookCatalogButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.Location = new System.Drawing.Point(65, 109);
            this.placeOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(303, 43);
            this.placeOrderButton.TabIndex = 1;
            this.placeOrderButton.Text = "Place Orders";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.Location = new System.Drawing.Point(65, 171);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(303, 43);
            this.generateReportButton.TabIndex = 2;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(65, 233);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(303, 43);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update Admin Profile";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // systemMaintButton
            // 
            this.systemMaintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemMaintButton.Location = new System.Drawing.Point(65, 299);
            this.systemMaintButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.systemMaintButton.Name = "systemMaintButton";
            this.systemMaintButton.Size = new System.Drawing.Size(303, 43);
            this.systemMaintButton.TabIndex = 4;
            this.systemMaintButton.Text = "System Maintenance";
            this.systemMaintButton.UseVisualStyleBackColor = true;
            this.systemMaintButton.Click += new System.EventHandler(this.systemMaintButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(65, 361);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(303, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exit 3-B.com";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.systemMaintButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.manageBookCatalogButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminHome";
            this.Text = "ADIMIN TASKS 3-B.com";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageBookCatalogButton;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button systemMaintButton;
        private System.Windows.Forms.Button button6;
    }
}