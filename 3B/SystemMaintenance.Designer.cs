namespace _3B
{
    partial class SystemMaintenance
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
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.statelbl = new System.Windows.Forms.Label();
            this.statePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.creditCardPanel = new System.Windows.Forms.Panel();
            this.doneBtn = new System.Windows.Forms.Button();
            this.moreCatBtn = new System.Windows.Forms.Button();
            this.fewerCatBtn = new System.Windows.Forms.Button();
            this.moreStatBtn = new System.Windows.Forms.Button();
            this.fewerStatBtn = new System.Windows.Forms.Button();
            this.moreCardBtn = new System.Windows.Forms.Button();
            this.fewerCardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // categoryPanel
            // 
            this.categoryPanel.Location = new System.Drawing.Point(139, 37);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(370, 144);
            this.categoryPanel.TabIndex = 1;
            // 
            // statelbl
            // 
            this.statelbl.AutoSize = true;
            this.statelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statelbl.Location = new System.Drawing.Point(59, 196);
            this.statelbl.Name = "statelbl";
            this.statelbl.Size = new System.Drawing.Size(76, 25);
            this.statelbl.TabIndex = 2;
            this.statelbl.Text = "State: ";
            // 
            // statePanel
            // 
            this.statePanel.Location = new System.Drawing.Point(139, 196);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(370, 144);
            this.statePanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Credit Card Type: ";
            // 
            // creditCardPanel
            // 
            this.creditCardPanel.Location = new System.Drawing.Point(139, 356);
            this.creditCardPanel.Name = "creditCardPanel";
            this.creditCardPanel.Size = new System.Drawing.Size(370, 144);
            this.creditCardPanel.TabIndex = 3;
            // 
            // doneBtn
            // 
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Location = new System.Drawing.Point(260, 545);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(124, 37);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            // 
            // moreCatBtn
            // 
            this.moreCatBtn.Location = new System.Drawing.Point(533, 57);
            this.moreCatBtn.Name = "moreCatBtn";
            this.moreCatBtn.Size = new System.Drawing.Size(88, 31);
            this.moreCatBtn.TabIndex = 5;
            this.moreCatBtn.Text = "More";
            this.moreCatBtn.UseVisualStyleBackColor = true;
            this.moreCatBtn.Click += new System.EventHandler(this.moreCatBtn_Click);
            // 
            // fewerCatBtn
            // 
            this.fewerCatBtn.Location = new System.Drawing.Point(533, 94);
            this.fewerCatBtn.Name = "fewerCatBtn";
            this.fewerCatBtn.Size = new System.Drawing.Size(88, 31);
            this.fewerCatBtn.TabIndex = 6;
            this.fewerCatBtn.Text = "Fewer";
            this.fewerCatBtn.UseVisualStyleBackColor = true;
            this.fewerCatBtn.Click += new System.EventHandler(this.fewerCatBtn_Click);
            // 
            // moreStatBtn
            // 
            this.moreStatBtn.Location = new System.Drawing.Point(533, 221);
            this.moreStatBtn.Name = "moreStatBtn";
            this.moreStatBtn.Size = new System.Drawing.Size(88, 31);
            this.moreStatBtn.TabIndex = 7;
            this.moreStatBtn.Text = "More";
            this.moreStatBtn.UseVisualStyleBackColor = true;
            this.moreStatBtn.Click += new System.EventHandler(this.moreStatBtn_Click);
            // 
            // fewerStatBtn
            // 
            this.fewerStatBtn.Location = new System.Drawing.Point(533, 258);
            this.fewerStatBtn.Name = "fewerStatBtn";
            this.fewerStatBtn.Size = new System.Drawing.Size(88, 31);
            this.fewerStatBtn.TabIndex = 8;
            this.fewerStatBtn.Text = "Fewer";
            this.fewerStatBtn.UseVisualStyleBackColor = true;
            this.fewerStatBtn.Click += new System.EventHandler(this.fewerStatBtn_Click);
            // 
            // moreCardBtn
            // 
            this.moreCardBtn.Location = new System.Drawing.Point(533, 376);
            this.moreCardBtn.Name = "moreCardBtn";
            this.moreCardBtn.Size = new System.Drawing.Size(88, 31);
            this.moreCardBtn.TabIndex = 9;
            this.moreCardBtn.Text = "More";
            this.moreCardBtn.UseVisualStyleBackColor = true;
            this.moreCardBtn.Click += new System.EventHandler(this.moreCardBtn_Click);
            // 
            // fewerCardBtn
            // 
            this.fewerCardBtn.Location = new System.Drawing.Point(533, 413);
            this.fewerCardBtn.Name = "fewerCardBtn";
            this.fewerCardBtn.Size = new System.Drawing.Size(88, 31);
            this.fewerCardBtn.TabIndex = 10;
            this.fewerCardBtn.Text = "Fewer";
            this.fewerCardBtn.UseVisualStyleBackColor = true;
            this.fewerCardBtn.Click += new System.EventHandler(this.fewerCardBtn_Click);
            // 
            // SystemMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 594);
            this.Controls.Add(this.fewerCardBtn);
            this.Controls.Add(this.moreCardBtn);
            this.Controls.Add(this.fewerStatBtn);
            this.Controls.Add(this.moreStatBtn);
            this.Controls.Add(this.fewerCatBtn);
            this.Controls.Add(this.moreCatBtn);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.creditCardPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statePanel);
            this.Controls.Add(this.statelbl);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SystemMaintenance";
            this.Text = "SystemMaintenance";
            this.Load += new System.EventHandler(this.SystemMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.Label statelbl;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel creditCardPanel;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button moreCatBtn;
        private System.Windows.Forms.Button fewerCatBtn;
        private System.Windows.Forms.Button moreStatBtn;
        private System.Windows.Forms.Button fewerStatBtn;
        private System.Windows.Forms.Button moreCardBtn;
        private System.Windows.Forms.Button fewerCardBtn;
    }
}