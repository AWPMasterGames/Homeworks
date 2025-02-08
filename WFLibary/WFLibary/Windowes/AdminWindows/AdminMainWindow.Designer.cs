namespace WFLibary.Windowes
{
    partial class AdminMainWindow
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
            addButton = new Button();
            outButton = new Button();
            listBox1 = new ListBox();
            inputButton = new Button();
            editButton = new Button();
            delleteButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightGreen;
            addButton.Location = new Point(52, 44);
            addButton.Name = "addButton";
            addButton.Size = new Size(196, 23);
            addButton.TabIndex = 0;
            addButton.Text = "Создать пользователя";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // outButton
            // 
            outButton.Location = new Point(620, 51);
            outButton.Name = "outButton";
            outButton.Size = new Size(125, 23);
            outButton.TabIndex = 1;
            outButton.Text = "Выйти";
            outButton.UseVisualStyleBackColor = true;
            outButton.Click += outButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(52, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(693, 259);
            listBox1.TabIndex = 2;
            // 
            // inputButton
            // 
            inputButton.Location = new Point(52, 397);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(173, 23);
            inputButton.TabIndex = 3;
            inputButton.Text = "Импорт";
            inputButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(584, 367);
            editButton.Name = "editButton";
            editButton.Size = new Size(161, 23);
            editButton.TabIndex = 4;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // delleteButton
            // 
            delleteButton.BackColor = Color.IndianRed;
            delleteButton.Location = new Point(584, 406);
            delleteButton.Name = "delleteButton";
            delleteButton.Size = new Size(161, 23);
            delleteButton.TabIndex = 5;
            delleteButton.Text = "удалить";
            delleteButton.UseVisualStyleBackColor = false;
            delleteButton.Click += delleteButton_Click;
            // 
            // AdminMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delleteButton);
            Controls.Add(editButton);
            Controls.Add(inputButton);
            Controls.Add(listBox1);
            Controls.Add(outButton);
            Controls.Add(addButton);
            Name = "AdminMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователи";
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button outButton;
        private ListBox listBox1;
        private Button inputButton;
        private Button editButton;
        private Button delleteButton;
    }
}