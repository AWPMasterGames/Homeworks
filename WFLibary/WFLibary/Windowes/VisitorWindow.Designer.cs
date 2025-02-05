namespace WFLibary.Windowes
{
    partial class VisitorWindow
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
            Username = new Label();
            UserLogin = new Label();
            UserPassword = new Label();
            UserPermmisions = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(41, 32);
            Username.Name = "Username";
            Username.Size = new Size(38, 15);
            Username.TabIndex = 0;
            Username.Text = "label1";
            // 
            // UserLogin
            // 
            UserLogin.AutoSize = true;
            UserLogin.Location = new Point(41, 63);
            UserLogin.Name = "UserLogin";
            UserLogin.Size = new Size(38, 15);
            UserLogin.TabIndex = 1;
            UserLogin.Text = "label2";
            // 
            // UserPassword
            // 
            UserPassword.AutoSize = true;
            UserPassword.Location = new Point(41, 90);
            UserPassword.Name = "UserPassword";
            UserPassword.Size = new Size(38, 15);
            UserPassword.TabIndex = 2;
            UserPassword.Text = "label1";
            // 
            // UserPermmisions
            // 
            UserPermmisions.AutoSize = true;
            UserPermmisions.Location = new Point(41, 120);
            UserPermmisions.Name = "UserPermmisions";
            UserPermmisions.Size = new Size(38, 15);
            UserPermmisions.TabIndex = 3;
            UserPermmisions.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(41, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 56);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VisitorWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(button1);
            Controls.Add(UserPermmisions);
            Controls.Add(UserPassword);
            Controls.Add(UserLogin);
            Controls.Add(Username);
            Name = "VisitorWindow";
            Text = "VisitorWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label UserLogin;
        private Label UserPassword;
        private Label UserPermmisions;
        private Button button1;
    }
}