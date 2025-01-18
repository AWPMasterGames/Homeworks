namespace WinFormsApp1
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
            Area = new GroupBox();
            InfoRect = new Label();
            RectangleInfo = new Label();
            ErrorInfo = new Label();
            SuspendLayout();
            // 
            // Area
            // 
            Area.Location = new Point(176, 54);
            Area.Name = "Area";
            Area.Size = new Size(612, 384);
            Area.TabIndex = 0;
            Area.TabStop = false;
            Area.Text = "Area";
            Area.MouseDown += MouseDownInArea;
            Area.MouseUp += MouseUpInArea;
            // 
            // InfoRect
            // 
            InfoRect.AutoSize = true;
            InfoRect.Location = new Point(0, 0);
            InfoRect.Name = "InfoRect";
            InfoRect.Size = new Size(163, 15);
            InfoRect.TabIndex = 1;
            InfoRect.Text = "Информация прямоуголька";
            // 
            // RectangleInfo
            // 
            RectangleInfo.AutoSize = true;
            RectangleInfo.Location = new Point(0, 25);
            RectangleInfo.Name = "RectangleInfo";
            RectangleInfo.Size = new Size(0, 15);
            RectangleInfo.TabIndex = 2;
            // 
            // ErrorInfo
            // 
            ErrorInfo.AutoSize = true;
            ErrorInfo.Location = new Point(176, 9);
            ErrorInfo.Name = "ErrorInfo";
            ErrorInfo.Size = new Size(53, 15);
            ErrorInfo.TabIndex = 3;
            ErrorInfo.Text = "Минимальный размер 10х10";
            ErrorInfo.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ErrorInfo);
            Controls.Add(RectangleInfo);
            Controls.Add(InfoRect);
            Controls.Add(Area);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Area;
        private Label InfoRect;
        private Label RectangleInfo;
        private Label ErrorInfo;
    }
}
