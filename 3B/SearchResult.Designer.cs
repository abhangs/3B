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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentItemCountLbl = new System.Windows.Forms.Label();
            this.manageCartBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.newSearchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.currentItemCountLbl);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // currentItemCountLbl
            // 
            this.currentItemCountLbl.AutoSize = true;
            this.currentItemCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentItemCountLbl.Location = new System.Drawing.Point(6, 18);
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
            this.manageCartBtn.Size = new System.Drawing.Size(285, 56);
            this.manageCartBtn.TabIndex = 1;
            this.manageCartBtn.Text = "Manage Shopping Cart";
            this.manageCartBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(12, 314);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(220, 45);
            this.checkoutBtn.TabIndex = 2;
            this.checkoutBtn.Text = "Proceed to Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            // 
            // newSearchBtn
            // 
            this.newSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSearchBtn.Location = new System.Drawing.Point(280, 314);
            this.newSearchBtn.Name = "newSearchBtn";
            this.newSearchBtn.Size = new System.Drawing.Size(220, 45);
            this.newSearchBtn.TabIndex = 3;
            this.newSearchBtn.Text = "New Search";
            this.newSearchBtn.UseVisualStyleBackColor = true;
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
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 234);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newSearchBtn);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.manageCartBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchResult";
            this.Text = "SearchResult";
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
        private System.Windows.Forms.ListView listView1;
    }
}