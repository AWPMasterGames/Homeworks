namespace WFLibary.Windowes.WorkerWindows
{
    partial class WorkerPanelWindow
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            импортToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            очиститьХранилищеToolStripMenuItem = new ToolStripMenuItem();
            видТекстаToolStripMenuItem = new ToolStripMenuItem();
            цветToolStripMenuItem = new ToolStripMenuItem();
            белыйToolStripMenuItem = new ToolStripMenuItem();
            жёлтыйToolStripMenuItem = new ToolStripMenuItem();
            оранжевыйToolStripMenuItem = new ToolStripMenuItem();
            зелёныйToolStripMenuItem = new ToolStripMenuItem();
            синийToolStripMenuItem = new ToolStripMenuItem();
            серыйToolStripMenuItem = new ToolStripMenuItem();
            крастыйToolStripMenuItem = new ToolStripMenuItem();
            розовыйToolStripMenuItem = new ToolStripMenuItem();
            фиолетовыйToolStripMenuItem = new ToolStripMenuItem();
            черныйToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            microsoftSansSerifToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            timesNewRomanToolStripMenuItem = new ToolStripMenuItem();
            размерТекстаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(217, 349);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(575, 52);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 129);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(534, 268);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(254, 21);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 4;
            label1.Text = "Название книги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(575, 21);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 5;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(254, 98);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 6;
            label3.Text = "Текст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 7;
            label4.Text = "Книги в хранилище";
            // 
            // button1
            // 
            button1.Location = new Point(470, 403);
            button1.Name = "button1";
            button1.Size = new Size(156, 35);
            button1.TabIndex = 8;
            button1.Text = "Изменить книгу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click_2;
            // 
            // button2
            // 
            button2.Location = new Point(632, 403);
            button2.Name = "button2";
            button2.Size = new Size(156, 35);
            button2.TabIndex = 9;
            button2.Text = "Удалить книгу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button3_Click_3;
            // 
            // button3
            // 
            button3.Location = new Point(308, 403);
            button3.Name = "button3";
            button3.Size = new Size(156, 35);
            button3.TabIndex = 10;
            button3.Text = "Добавить книгу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(25, 407);
            button4.Name = "button4";
            button4.Size = new Size(140, 35);
            button4.TabIndex = 11;
            button4.Text = "Вернуться";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видТекстаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { импортToolStripMenuItem, сохранитьToolStripMenuItem, очиститьХранилищеToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // импортToolStripMenuItem
            // 
            импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            импортToolStripMenuItem.Size = new Size(193, 22);
            импортToolStripMenuItem.Text = "Импорт";
            импортToolStripMenuItem.Click += импортToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(193, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // очиститьХранилищеToolStripMenuItem
            // 
            очиститьХранилищеToolStripMenuItem.Name = "очиститьХранилищеToolStripMenuItem";
            очиститьХранилищеToolStripMenuItem.Size = new Size(193, 22);
            очиститьХранилищеToolStripMenuItem.Text = "Очистить хранилище";
            очиститьХранилищеToolStripMenuItem.Click += очиститьХранилищеToolStripMenuItem_Click;
            // 
            // видТекстаToolStripMenuItem
            // 
            видТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветToolStripMenuItem, шрифтToolStripMenuItem, размерТекстаToolStripMenuItem });
            видТекстаToolStripMenuItem.Name = "видТекстаToolStripMenuItem";
            видТекстаToolStripMenuItem.Size = new Size(76, 20);
            видТекстаToolStripMenuItem.Text = "Вид текста";
            // 
            // цветToolStripMenuItem
            // 
            цветToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { белыйToolStripMenuItem, жёлтыйToolStripMenuItem, оранжевыйToolStripMenuItem, зелёныйToolStripMenuItem, синийToolStripMenuItem, серыйToolStripMenuItem, крастыйToolStripMenuItem, розовыйToolStripMenuItem, фиолетовыйToolStripMenuItem, черныйToolStripMenuItem });
            цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            цветToolStripMenuItem.Size = new Size(151, 22);
            цветToolStripMenuItem.Text = "Цвет";
            // 
            // белыйToolStripMenuItem
            // 
            белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            белыйToolStripMenuItem.Size = new Size(144, 22);
            белыйToolStripMenuItem.Text = "Белый";
            белыйToolStripMenuItem.Click += белыйToolStripMenuItem_Click;
            // 
            // жёлтыйToolStripMenuItem
            // 
            жёлтыйToolStripMenuItem.Name = "жёлтыйToolStripMenuItem";
            жёлтыйToolStripMenuItem.Size = new Size(144, 22);
            жёлтыйToolStripMenuItem.Text = "Жёлтый";
            жёлтыйToolStripMenuItem.Click += жёлтыйToolStripMenuItem_Click;
            // 
            // оранжевыйToolStripMenuItem
            // 
            оранжевыйToolStripMenuItem.Name = "оранжевыйToolStripMenuItem";
            оранжевыйToolStripMenuItem.Size = new Size(144, 22);
            оранжевыйToolStripMenuItem.Text = "Оранжевый";
            оранжевыйToolStripMenuItem.Click += оранжевыйToolStripMenuItem_Click;
            // 
            // зелёныйToolStripMenuItem
            // 
            зелёныйToolStripMenuItem.Name = "зелёныйToolStripMenuItem";
            зелёныйToolStripMenuItem.Size = new Size(144, 22);
            зелёныйToolStripMenuItem.Text = "Зелёный";
            зелёныйToolStripMenuItem.Click += зелёныйToolStripMenuItem_Click;
            // 
            // синийToolStripMenuItem
            // 
            синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            синийToolStripMenuItem.Size = new Size(144, 22);
            синийToolStripMenuItem.Text = "Синий";
            синийToolStripMenuItem.Click += синийToolStripMenuItem_Click;
            // 
            // серыйToolStripMenuItem
            // 
            серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            серыйToolStripMenuItem.Size = new Size(144, 22);
            серыйToolStripMenuItem.Text = "Серый";
            серыйToolStripMenuItem.Click += серыйToolStripMenuItem_Click;
            // 
            // крастыйToolStripMenuItem
            // 
            крастыйToolStripMenuItem.Name = "крастыйToolStripMenuItem";
            крастыйToolStripMenuItem.Size = new Size(144, 22);
            крастыйToolStripMenuItem.Text = "Красный";
            крастыйToolStripMenuItem.Click += крастыйToolStripMenuItem_Click;
            // 
            // розовыйToolStripMenuItem
            // 
            розовыйToolStripMenuItem.Name = "розовыйToolStripMenuItem";
            розовыйToolStripMenuItem.Size = new Size(144, 22);
            розовыйToolStripMenuItem.Text = "Розовый";
            розовыйToolStripMenuItem.Click += розовыйToolStripMenuItem_Click;
            // 
            // фиолетовыйToolStripMenuItem
            // 
            фиолетовыйToolStripMenuItem.Name = "фиолетовыйToolStripMenuItem";
            фиолетовыйToolStripMenuItem.Size = new Size(144, 22);
            фиолетовыйToolStripMenuItem.Text = "Фиолетовый";
            фиолетовыйToolStripMenuItem.Click += фиолетовыйToolStripMenuItem_Click;
            // 
            // черныйToolStripMenuItem
            // 
            черныйToolStripMenuItem.Name = "черныйToolStripMenuItem";
            черныйToolStripMenuItem.Size = new Size(144, 22);
            черныйToolStripMenuItem.Text = "Черный";
            черныйToolStripMenuItem.Click += черныйToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { microsoftSansSerifToolStripMenuItem, boldToolStripMenuItem, timesNewRomanToolStripMenuItem });
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(151, 22);
            шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // microsoftSansSerifToolStripMenuItem
            // 
            microsoftSansSerifToolStripMenuItem.Name = "microsoftSansSerifToolStripMenuItem";
            microsoftSansSerifToolStripMenuItem.Size = new Size(178, 22);
            microsoftSansSerifToolStripMenuItem.Text = "Microsoft Sans Serif";
            microsoftSansSerifToolStripMenuItem.Click += microsoftSansSerifToolStripMenuItem_Click;
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(178, 22);
            boldToolStripMenuItem.Text = "Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // timesNewRomanToolStripMenuItem
            // 
            timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            timesNewRomanToolStripMenuItem.Size = new Size(178, 22);
            timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            timesNewRomanToolStripMenuItem.Click += timesNewRomanToolStripMenuItem_Click;
            // 
            // размерТекстаToolStripMenuItem
            // 
            размерТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10, toolStripMenuItem11, toolStripMenuItem12 });
            размерТекстаToolStripMenuItem.Name = "размерТекстаToolStripMenuItem";
            размерТекстаToolStripMenuItem.Size = new Size(151, 22);
            размерТекстаToolStripMenuItem.Text = "Размер текста";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(86, 22);
            toolStripMenuItem2.Text = "10";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(86, 22);
            toolStripMenuItem3.Text = "12";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(86, 22);
            toolStripMenuItem4.Text = "14";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(86, 22);
            toolStripMenuItem5.Text = "16";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(86, 22);
            toolStripMenuItem6.Text = "18";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(86, 22);
            toolStripMenuItem7.Text = "20";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(86, 22);
            toolStripMenuItem8.Text = "22";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(86, 22);
            toolStripMenuItem9.Text = "24";
            toolStripMenuItem9.Click += toolStripMenuItem9_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(86, 22);
            toolStripMenuItem10.Text = "26";
            toolStripMenuItem10.Click += toolStripMenuItem10_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(86, 22);
            toolStripMenuItem11.Text = "28";
            toolStripMenuItem11.Click += toolStripMenuItem11_Click;
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(86, 22);
            toolStripMenuItem12.Text = "30";
            toolStripMenuItem12.Click += toolStripMenuItem12_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // WorkerPanelWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "WorkerPanelWindow";
            Text = "WorkerPanelWindow";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem импортToolStripMenuItem;
        private ToolStripMenuItem видТекстаToolStripMenuItem;
        private ToolStripMenuItem цветToolStripMenuItem;
        private ToolStripMenuItem белыйToolStripMenuItem;
        private ToolStripMenuItem жёлтыйToolStripMenuItem;
        private ToolStripMenuItem оранжевыйToolStripMenuItem;
        private ToolStripMenuItem зелёныйToolStripMenuItem;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripMenuItem серыйToolStripMenuItem;
        private ToolStripMenuItem крастыйToolStripMenuItem;
        private ToolStripMenuItem розовыйToolStripMenuItem;
        private ToolStripMenuItem фиолетовыйToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem размерТекстаToolStripMenuItem;
        private ToolStripMenuItem microsoftSansSerifToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem черныйToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem очиститьХранилищеToolStripMenuItem;
    }
}