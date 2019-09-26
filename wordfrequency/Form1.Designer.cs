namespace wordfrequency
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userTextInsert = new System.Windows.Forms.RichTextBox();
            this.analyseButton = new System.Windows.Forms.Button();
            this.wordCountDisplay = new System.Windows.Forms.RichTextBox();
            this.characterCountDisplay = new System.Windows.Forms.RichTextBox();
            this.wordFrequency = new System.Windows.Forms.RichTextBox();
            this.familyFrequency = new System.Windows.Forms.RichTextBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userTextInsert
            // 
            this.userTextInsert.Location = new System.Drawing.Point(12, 30);
            this.userTextInsert.Name = "userTextInsert";
            this.userTextInsert.Size = new System.Drawing.Size(427, 232);
            this.userTextInsert.TabIndex = 0;
            this.userTextInsert.Text = "";
            // 
            // analyseButton
            // 
            this.analyseButton.Location = new System.Drawing.Point(12, 268);
            this.analyseButton.Name = "analyseButton";
            this.analyseButton.Size = new System.Drawing.Size(422, 45);
            this.analyseButton.TabIndex = 1;
            this.analyseButton.Text = "Analyze";
            this.analyseButton.UseVisualStyleBackColor = true;
            this.analyseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // wordCountDisplay
            // 
            this.wordCountDisplay.Location = new System.Drawing.Point(612, 72);
            this.wordCountDisplay.Name = "wordCountDisplay";
            this.wordCountDisplay.Size = new System.Drawing.Size(150, 101);
            this.wordCountDisplay.TabIndex = 6;
            this.wordCountDisplay.Text = "";
            this.wordCountDisplay.TextChanged += new System.EventHandler(this.wordCountDisplay_TextChanged);
            // 
            // characterCountDisplay
            // 
            this.characterCountDisplay.Location = new System.Drawing.Point(456, 72);
            this.characterCountDisplay.Name = "characterCountDisplay";
            this.characterCountDisplay.Size = new System.Drawing.Size(150, 101);
            this.characterCountDisplay.TabIndex = 7;
            this.characterCountDisplay.Text = "";
            // 
            // wordFrequency
            // 
            this.wordFrequency.Location = new System.Drawing.Point(12, 339);
            this.wordFrequency.Name = "wordFrequency";
            this.wordFrequency.Size = new System.Drawing.Size(426, 317);
            this.wordFrequency.TabIndex = 8;
            this.wordFrequency.Text = "";
            // 
            // familyFrequency
            // 
            this.familyFrequency.Location = new System.Drawing.Point(440, 339);
            this.familyFrequency.Name = "familyFrequency";
            this.familyFrequency.Size = new System.Drawing.Size(348, 317);
            this.familyFrequency.TabIndex = 9;
            this.familyFrequency.Text = "";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(440, 268);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(348, 45);
            this.clearAllButton.TabIndex = 10;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(12, 316);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(49, 17);
            this.lable1.TabIndex = 11;
            this.lable1.Text = "Words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tally";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Percentage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Root Words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tally";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Percentage ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Enter Text:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Character Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Word Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 663);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.familyFrequency);
            this.Controls.Add(this.wordFrequency);
            this.Controls.Add(this.characterCountDisplay);
            this.Controls.Add(this.wordCountDisplay);
            this.Controls.Add(this.analyseButton);
            this.Controls.Add(this.userTextInsert);
            this.Name = "Form1";
            this.Text = "Word Frequency Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox userTextInsert;
        private System.Windows.Forms.Button analyseButton;
        private System.Windows.Forms.RichTextBox wordCountDisplay;
        private System.Windows.Forms.RichTextBox characterCountDisplay;
        private System.Windows.Forms.RichTextBox wordFrequency;
        private System.Windows.Forms.RichTextBox familyFrequency;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

