namespace GuessUserNumber
{
    partial class Form1
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
            UserInputTB = new TextBox();
            label1 = new Label();
            UserInputL = new Label();
            BotExportL = new Label();
            BotTryCount = new Label();
            button1 = new Button();
            ErrorLabel = new Label();
            SuspendLayout();
            // 
            // UserInputTB
            // 
            UserInputTB.Location = new Point(29, 47);
            UserInputTB.Name = "UserInputTB";
            UserInputTB.Size = new Size(90, 23);
            UserInputTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите число:";
            // 
            // UserInputL
            // 
            UserInputL.AutoSize = true;
            UserInputL.Location = new Point(30, 50);
            UserInputL.Name = "UserInputL";
            UserInputL.Size = new Size(64, 15);
            UserInputL.TabIndex = 0;
            UserInputL.Text = "UserInputL";
            UserInputL.Visible = false;
            // 
            // BotExportL
            // 
            BotExportL.Location = new Point(0, 0);
            BotExportL.Name = "BotExportL";
            BotExportL.Size = new Size(100, 23);
            BotExportL.TabIndex = 9;
            // 
            // BotTryCount
            // 
            BotTryCount.Location = new Point(0, 0);
            BotTryCount.Name = "BotTryCount";
            BotTryCount.Size = new Size(100, 23);
            BotTryCount.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(173, 30);
            button1.Name = "button1";
            button1.Size = new Size(96, 40);
            button1.TabIndex = 7;
            button1.Text = "Найти число";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(26, 86);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(38, 15);
            ErrorLabel.TabIndex = 10;
            ErrorLabel.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 139);
            Controls.Add(ErrorLabel);
            Controls.Add(button1);
            Controls.Add(BotTryCount);
            Controls.Add(BotExportL);
            Controls.Add(UserInputL);
            Controls.Add(label1);
            Controls.Add(UserInputTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserInputTB;
        private Label label1;
        private Label UserInputL;
        private Label BotExportL;
        private Label BotTryCount;
        private Button button1;
        private Label ErrorLabel;
    }
}
