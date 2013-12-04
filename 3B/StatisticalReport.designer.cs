namespace _3B
{
    partial class StatisticalReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avgSalesTxtBox = new System.Windows.Forms.TextBox();
            this.avgBooksTxtBox = new System.Windows.Forms.TextBox();
            this.avgCustomerTxtBox = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average amount of sales per customer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average number of books per purchase transaction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average number of customers per day:";
            // 
            // avgSalesTxtBox
            // 
            this.avgSalesTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgSalesTxtBox.Location = new System.Drawing.Point(465, 58);
            this.avgSalesTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avgSalesTxtBox.Name = "avgSalesTxtBox";
            this.avgSalesTxtBox.ReadOnly = true;
            this.avgSalesTxtBox.Size = new System.Drawing.Size(111, 26);
            this.avgSalesTxtBox.TabIndex = 3;
            this.avgSalesTxtBox.Text = "36.99";
            // 
            // avgBooksTxtBox
            // 
            this.avgBooksTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgBooksTxtBox.Location = new System.Drawing.Point(585, 108);
            this.avgBooksTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avgBooksTxtBox.Name = "avgBooksTxtBox";
            this.avgBooksTxtBox.ReadOnly = true;
            this.avgBooksTxtBox.Size = new System.Drawing.Size(111, 26);
            this.avgBooksTxtBox.TabIndex = 4;
            this.avgBooksTxtBox.Text = "3";
            // 
            // avgCustomerTxtBox
            // 
            this.avgCustomerTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgCustomerTxtBox.Location = new System.Drawing.Point(430, 164);
            this.avgCustomerTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avgCustomerTxtBox.Name = "avgCustomerTxtBox";
            this.avgCustomerTxtBox.ReadOnly = true;
            this.avgCustomerTxtBox.Size = new System.Drawing.Size(111, 26);
            this.avgCustomerTxtBox.TabIndex = 5;
            this.avgCustomerTxtBox.Text = "6";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(275, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 42);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // StatisticalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 335);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.avgCustomerTxtBox);
            this.Controls.Add(this.avgBooksTxtBox);
            this.Controls.Add(this.avgSalesTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatisticalReport";
            this.Text = "StatisticalReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticalReport_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatisticalReport_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avgSalesTxtBox;
        private System.Windows.Forms.TextBox avgBooksTxtBox;
        private System.Windows.Forms.TextBox avgCustomerTxtBox;
        private System.Windows.Forms.Button btnOk;
    }
}