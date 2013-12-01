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
            this.fourth = new System.Windows.Forms.RadioButton();
            this.fifth = new System.Windows.Forms.RadioButton();
            this.printButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtons = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            // fourth
            // 
            this.fourth.AutoSize = true;
            this.fourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourth.Location = new System.Drawing.Point(75, 229);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(703, 29);
            this.fourth.TabIndex = 3;
            this.fourth.TabStop = true;
            this.fourth.Text = "List of the most expensive books for each book category in descending order.";
            this.fourth.UseVisualStyleBackColor = true;
            // 
            // fifth
            // 
            this.fifth.AutoSize = true;
            this.fifth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifth.Location = new System.Drawing.Point(75, 284);
            this.fifth.Name = "fifth";
            this.fifth.Size = new System.Drawing.Size(603, 29);
            this.fifth.TabIndex = 4;
            this.fifth.TabStop = true;
            this.fifth.Text = "Total number of distinct buyers for each category in the last month";
            this.fifth.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(235, 496);
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
            this.doneButton.Location = new System.Drawing.Point(516, 496);
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
            this.radioButtons.Controls.Add(this.radioButton1);
            this.radioButtons.Controls.Add(this.first);
            this.radioButtons.Controls.Add(this.second);
            this.radioButtons.Controls.Add(this.third);
            this.radioButtons.Controls.Add(this.fourth);
            this.radioButtons.Controls.Add(this.fifth);
            this.radioButtons.Location = new System.Drawing.Point(35, 63);
            this.radioButtons.Name = "radioButtons";
            this.radioButtons.Size = new System.Drawing.Size(813, 413);
            this.radioButtons.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(75, 336);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(182, 29);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Statistical Report";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 594);
            this.Controls.Add(this.radioButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.printButton);
            this.Name = "ReportMenu";
            this.Text = "Report Menu 3-B.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportMenu_FormClosing);
            this.radioButtons.ResumeLayout(false);
            this.radioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.RadioButton second;
        private System.Windows.Forms.RadioButton third;
        private System.Windows.Forms.RadioButton fourth;
        private System.Windows.Forms.RadioButton fifth;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel radioButtons;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}