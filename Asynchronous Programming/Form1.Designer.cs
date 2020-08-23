namespace Syed_Rumail_Exercise03
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
            this.Part_1_box = new System.Windows.Forms.GroupBox();
            this.fact_button = new System.Windows.Forms.Button();
            this.factorial_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Even_Odd_Btn = new System.Windows.Forms.Button();
            this.Even_OddTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputLB = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.HighIndTB = new System.Windows.Forms.TextBox();
            this.LowIndTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchValBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Values = new System.Windows.Forms.ListBox();
            this.ValGenBtn = new System.Windows.Forms.Button();
            this.CharRB = new System.Windows.Forms.RadioButton();
            this.DoubleRB = new System.Windows.Forms.RadioButton();
            this.IntRB = new System.Windows.Forms.RadioButton();
            this.Part_1_box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Part_1_box
            // 
            this.Part_1_box.Controls.Add(this.fact_button);
            this.Part_1_box.Controls.Add(this.factorial_input);
            this.Part_1_box.Controls.Add(this.label1);
            this.Part_1_box.Location = new System.Drawing.Point(12, 24);
            this.Part_1_box.Name = "Part_1_box";
            this.Part_1_box.Size = new System.Drawing.Size(254, 128);
            this.Part_1_box.TabIndex = 0;
            this.Part_1_box.TabStop = false;
            this.Part_1_box.Text = "(1) Calculate Asyncronously";
            // 
            // fact_button
            // 
            this.fact_button.Location = new System.Drawing.Point(38, 72);
            this.fact_button.Name = "fact_button";
            this.fact_button.Size = new System.Drawing.Size(150, 23);
            this.fact_button.TabIndex = 2;
            this.fact_button.Text = "Calculate";
            this.fact_button.UseVisualStyleBackColor = true;
            this.fact_button.Click += new System.EventHandler(this.fact_button_Click);
            // 
            // factorial_input
            // 
            this.factorial_input.Location = new System.Drawing.Point(128, 29);
            this.factorial_input.Name = "factorial_input";
            this.factorial_input.Size = new System.Drawing.Size(100, 20);
            this.factorial_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Get Factorial of :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Even_Odd_Btn);
            this.groupBox1.Controls.Add(this.Even_OddTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(2) Check for Even/Odd";
            // 
            // Even_Odd_Btn
            // 
            this.Even_Odd_Btn.Location = new System.Drawing.Point(38, 91);
            this.Even_Odd_Btn.Name = "Even_Odd_Btn";
            this.Even_Odd_Btn.Size = new System.Drawing.Size(150, 23);
            this.Even_Odd_Btn.TabIndex = 4;
            this.Even_Odd_Btn.Text = "Check For Even or Odd";
            this.Even_Odd_Btn.UseVisualStyleBackColor = true;
            this.Even_Odd_Btn.Click += new System.EventHandler(this.Even_Odd_Btn_Click);
            // 
            // Even_OddTB
            // 
            this.Even_OddTB.Location = new System.Drawing.Point(128, 50);
            this.Even_OddTB.Name = "Even_OddTB";
            this.Even_OddTB.Size = new System.Drawing.Size(100, 20);
            this.Even_OddTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Number :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutputLB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DisplayBtn);
            this.groupBox2.Controls.Add(this.HighIndTB);
            this.groupBox2.Controls.Add(this.LowIndTB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SearchValBtn);
            this.groupBox2.Controls.Add(this.searchTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Values);
            this.groupBox2.Controls.Add(this.ValGenBtn);
            this.groupBox2.Controls.Add(this.CharRB);
            this.groupBox2.Controls.Add(this.DoubleRB);
            this.groupBox2.Controls.Add(this.IntRB);
            this.groupBox2.Location = new System.Drawing.Point(289, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 307);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(3) Display List of Values and Search";
            // 
            // OutputLB
            // 
            this.OutputLB.FormattingEnabled = true;
            this.OutputLB.Location = new System.Drawing.Point(114, 231);
            this.OutputLB.Name = "OutputLB";
            this.OutputLB.Size = new System.Drawing.Size(188, 56);
            this.OutputLB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Output of Values between Low and High";
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(259, 128);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(88, 23);
            this.DisplayBtn.TabIndex = 11;
            this.DisplayBtn.Text = "Display";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // HighIndTB
            // 
            this.HighIndTB.Location = new System.Drawing.Point(208, 149);
            this.HighIndTB.Name = "HighIndTB";
            this.HighIndTB.Size = new System.Drawing.Size(42, 20);
            this.HighIndTB.TabIndex = 10;
            // 
            // LowIndTB
            // 
            this.LowIndTB.Location = new System.Drawing.Point(208, 108);
            this.LowIndTB.Name = "LowIndTB";
            this.LowIndTB.Size = new System.Drawing.Size(42, 20);
            this.LowIndTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter High Index :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Low Index :";
            // 
            // SearchValBtn
            // 
            this.SearchValBtn.Location = new System.Drawing.Point(259, 67);
            this.SearchValBtn.Name = "SearchValBtn";
            this.SearchValBtn.Size = new System.Drawing.Size(88, 23);
            this.SearchValBtn.TabIndex = 6;
            this.SearchValBtn.Text = "Search";
            this.SearchValBtn.UseVisualStyleBackColor = true;
            this.SearchValBtn.Click += new System.EventHandler(this.SearchValBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(208, 69);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(42, 20);
            this.searchTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " Input Values To Search :";
            // 
            // Values
            // 
            this.Values.FormattingEnabled = true;
            this.Values.Location = new System.Drawing.Point(16, 56);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(58, 238);
            this.Values.TabIndex = 4;
            // 
            // ValGenBtn
            // 
            this.ValGenBtn.Location = new System.Drawing.Point(197, 24);
            this.ValGenBtn.Name = "ValGenBtn";
            this.ValGenBtn.Size = new System.Drawing.Size(150, 23);
            this.ValGenBtn.TabIndex = 3;
            this.ValGenBtn.Text = "Generate Value";
            this.ValGenBtn.UseVisualStyleBackColor = true;
            this.ValGenBtn.Click += new System.EventHandler(this.ValGenBtn_Click);
            // 
            // CharRB
            // 
            this.CharRB.AutoSize = true;
            this.CharRB.Location = new System.Drawing.Point(144, 27);
            this.CharRB.Name = "CharRB";
            this.CharRB.Size = new System.Drawing.Size(47, 17);
            this.CharRB.TabIndex = 2;
            this.CharRB.TabStop = true;
            this.CharRB.Text = "Char";
            this.CharRB.UseVisualStyleBackColor = true;
            // 
            // DoubleRB
            // 
            this.DoubleRB.AutoSize = true;
            this.DoubleRB.Location = new System.Drawing.Point(80, 27);
            this.DoubleRB.Name = "DoubleRB";
            this.DoubleRB.Size = new System.Drawing.Size(59, 17);
            this.DoubleRB.TabIndex = 1;
            this.DoubleRB.TabStop = true;
            this.DoubleRB.Text = "Double";
            this.DoubleRB.UseVisualStyleBackColor = true;
            // 
            // IntRB
            // 
            this.IntRB.AutoSize = true;
            this.IntRB.Location = new System.Drawing.Point(16, 27);
            this.IntRB.Name = "IntRB";
            this.IntRB.Size = new System.Drawing.Size(58, 17);
            this.IntRB.TabIndex = 0;
            this.IntRB.TabStop = true;
            this.IntRB.Text = "Integer";
            this.IntRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Part_1_box);
            this.Name = "Form1";
            this.Text = "Asynchronous Programming";
            this.Part_1_box.ResumeLayout(false);
            this.Part_1_box.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Part_1_box;
        private System.Windows.Forms.Button fact_button;
        private System.Windows.Forms.TextBox factorial_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Even_Odd_Btn;
        private System.Windows.Forms.TextBox Even_OddTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox OutputLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.TextBox HighIndTB;
        private System.Windows.Forms.TextBox LowIndTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchValBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Values;
        private System.Windows.Forms.Button ValGenBtn;
        private System.Windows.Forms.RadioButton CharRB;
        private System.Windows.Forms.RadioButton DoubleRB;
        private System.Windows.Forms.RadioButton IntRB;
    }
}

