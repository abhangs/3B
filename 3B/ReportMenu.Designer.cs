namespace _3B
{
    partial class ReportMenu
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
            this.first = new System.Windows.Forms.RadioButton();
            this.second = new System.Windows.Forms.RadioButton();
            this.third = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.printButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtons = new System.Windows.Forms.Panel();
            this.radioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(75, 66);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(429, 29);
            this.first.TabIndex = 0;
            this.first.TabStop = true;
            this.first.Text = "Total sales from last month for each category.";
            this.first.UseVisualStyleBackColor = true;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(75, 121);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(462, 29);
            this.second.TabIndex = 1;
            this.second.TabStop = true;
            this.second.Text = "Total number of books in stock for each category.";
            this.second.UseVisualStyleBackColor = true;
            // 
            // third
            // 
            this.third.AutoSize = true;
            this.third.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.third.Location = new System.Drawing.Point(75, 177);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(693, 29);
            this.third.TabIndex = 2;
            this.third.TabStop = true;
            this.third.Text = "List of top ten best sellers, in descending order of sales for last three months." +
    "";
            this.third.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(75, 229);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(703, 29);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "List of the most expensive books for each book category in descending order.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(75, 279);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(603, 29);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Total number of distinct buyers for each category in the last month";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(75, 328);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(371, 29);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Average amount of sales per customer";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(75, 376);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(480, 29);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Average number of books per purchase transaction";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(75, 429);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(368, 29);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Average number of customers per day";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(255, 579);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(121, 51);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(480, 579);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(121, 51);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Report Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtons
            // 
            this.radioButtons.Controls.Add(this.first);
            this.radioButtons.Controls.Add(this.second);
            this.radioButtons.Controls.Add(this.third);
            this.radioButtons.Controls.Add(this.radioButton1);
            this.radioButtons.Controls.Add(this.radioButton5);
            this.radioButtons.Controls.Add(this.radioButton2);
            this.radioButtons.Controls.Add(this.radioButton4);
            this.radioButtons.Controls.Add(this.radioButton3);
            this.radioButtons.Location = new System.Drawing.Point(35, 63);
            this.radioButtons.Name = "radioButtons";
            this.radioButtons.Size = new System.Drawing.Size(813, 482);
            this.radioButtons.TabIndex = 11;
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 700);
            this.Controls.Add(this.radioButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.printButton);
            this.Name = "ReportMenu";
            this.Text = "Report Menu 3-B.com";
            this.radioButtons.ResumeLayout(false);
            this.radioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.RadioButton second;
        private System.Windows.Forms.RadioButton third;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel radioButtons;
    }
}