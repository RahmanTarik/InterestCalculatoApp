namespace InterestCalculatoApp
{
    partial class InterstCalculatorFOrm
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
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateInterestButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time (in Year):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance:";
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(127, 10);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.bankNameComboBox.TabIndex = 3;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(127, 45);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(120, 20);
            this.timeTextBox.TabIndex = 4;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(127, 77);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(120, 20);
            this.balanceTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interst = ";
            // 
            // calculateInterestButton
            // 
            this.calculateInterestButton.Location = new System.Drawing.Point(91, 182);
            this.calculateInterestButton.Name = "calculateInterestButton";
            this.calculateInterestButton.Size = new System.Drawing.Size(156, 39);
            this.calculateInterestButton.TabIndex = 7;
            this.calculateInterestButton.Text = "Calculate Interest";
            this.calculateInterestButton.UseVisualStyleBackColor = true;
            this.calculateInterestButton.Click += new System.EventHandler(this.calculateInterestButton_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Controls.Add(this.calculateInterestButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.balanceTextBox);
            this.groupBox1.Controls.Add(this.timeTextBox);
            this.groupBox1.Controls.Add(this.bankNameComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Location = new System.Drawing.Point(54, 133);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 13);
            this.resultTextBox.TabIndex = 8;
            // 
            // InterstCalculatorFOrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "InterstCalculatorFOrm";
            this.Text = "Interest Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateInterestButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

