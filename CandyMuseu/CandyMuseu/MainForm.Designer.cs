namespace CandyMuseu
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CashBox = new GroupBox();
            button2 = new Button();
            CostL = new Label();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            CashBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // CashBox
            // 
            CashBox.Controls.Add(button2);
            CashBox.Controls.Add(CostL);
            CashBox.Controls.Add(label1);
            CashBox.Controls.Add(checkedListBox1);
            CashBox.Controls.Add(button1);
            CashBox.Controls.Add(numericUpDown1);
            CashBox.Controls.Add(comboBox1);
            CashBox.Location = new Point(12, 12);
            CashBox.Name = "CashBox";
            CashBox.Size = new Size(684, 361);
            CashBox.TabIndex = 0;
            CashBox.TabStop = false;
            CashBox.Text = "Касса";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(286, 313);
            button2.Name = "button2";
            button2.Size = new Size(140, 33);
            button2.TabIndex = 6;
            button2.Text = "Выдать чек";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CostL
            // 
            CostL.AutoSize = true;
            CostL.Font = new Font("Segoe UI", 15F);
            CostL.Location = new Point(570, 276);
            CostL.Name = "CostL";
            CostL.Size = new Size(23, 28);
            CostL.TabIndex = 5;
            CostL.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(614, 288);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 4;
            label1.Text = "р.";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(23, 124);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(629, 94);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_CheckedIndex;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(229, 73);
            button1.Name = "button1";
            button1.Size = new Size(231, 29);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(500, 35);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(437, 23);
            comboBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(21, 397);
            button3.Name = "button3";
            button3.Size = new Size(228, 59);
            button3.TabIndex = 1;
            button3.Text = "Склад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Location = new Point(457, 397);
            button4.Name = "button4";
            button4.Size = new Size(228, 59);
            button4.TabIndex = 2;
            button4.Text = "Закончить смену";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 468);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(CashBox);
            Name = "MainForm";
            Text = "MainWindow";
            CashBox.ResumeLayout(false);
            CashBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CashBox;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label CostL;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
