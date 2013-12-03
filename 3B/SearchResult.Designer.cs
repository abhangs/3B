namespace _3B
{
    partial class SearchResult
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentItemCountLbl = new System.Windows.Forms.Label();
            this.manageCartBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.newSearchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.currentItemCountLbl);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // currentItemCountLbl
            // 
            this.currentItemCountLbl.AutoSize = true;
            this.currentItemCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentItemCountLbl.Location = new System.Drawing.Point(15, 13);
            this.currentItemCountLbl.Name = "currentItemCountLbl";
            this.currentItemCountLbl.Size = new System.Drawing.Size(360, 29);
            this.currentItemCountLbl.TabIndex = 0;
            this.currentItemCountLbl.Text = "Your Shopping Cart has items";
            // 
            // manageCartBtn
            // 
            this.manageCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCartBtn.Location = new System.Drawing.Point(488, 12);
            this.manageCartBtn.Name = "manageCartBtn";
            this.manageCartBtn.Size = new System.Drawing.Size(285, 45);
            this.manageCartBtn.TabIndex = 1;
            this.manageCartBtn.Text = "Manage Shopping Cart";
            this.manageCartBtn.UseVisualStyleBackColor = true;
            this.manageCartBtn.Click += new System.EventHandler(this.manageCartBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(12, 314);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(262, 45);
            this.checkoutBtn.TabIndex = 2;
            this.checkoutBtn.Text = "Proceed to Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // newSearchBtn
            // 
            this.newSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSearchBtn.Location = new System.Drawing.Point(298, 314);
            this.newSearchBtn.Name = "newSearchBtn";
            this.newSearchBtn.Size = new System.Drawing.Size(220, 45);
            this.newSearchBtn.TabIndex = 3;
            this.newSearchBtn.Text = "New Search";
            this.newSearchBtn.UseVisualStyleBackColor = true;
            this.newSearchBtn.Click += new System.EventHandler(this.newSearchBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(553, 314);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(220, 45);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT 3-B.Com";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 245);
            this.panel1.TabIndex = 5;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newSearchBtn);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.manageCartBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchResult";
            this.Text = "Search Result - 3-B.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchResult_FormClosing);
            this.Load += new System.EventHandler(this.SearchResult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentItemCountLbl;
        private System.Windows.Forms.Button manageCartBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Button newSearchBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Panel panel1;
    }
}