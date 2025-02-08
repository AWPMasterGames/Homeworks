using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLibary.Windowes.WorkerWindows
{
    public partial class WorkerPanelWindow : Form
    {
        private Random random = new Random();
        private string TextStyle = "Microsoft Sans Serif";
        private int TextSize = 10;
        public WorkerPanelWindow()
        {
            InitializeComponent();
            listBox1.Items.AddRange(BooksStorage.GetBooksOfStorage().ToArray());
        }
        private int GenerateBookId()
        {
            int id = random.Next(0, 1000);
            for (int i = 0; i < BooksStorage.Books.Count; i++)
            {
                if (BooksStorage.Books[i].BookId == id)
                {
                    id = GenerateBookId();
                }
            }
            return id;
        }
        private bool BookExistInStorage(string title)
        {
            for (int i = 0; i < BooksStorage.Books.Count; i++)
            {
                if (title == BooksStorage.Books[i].Title) { return true; }
            }
            return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3) return;
            if (textBox2.Text.Length < 3) return;
            if (textBox3.Text.Length < 3) return;

            if (!BookExistInStorage(textBox1.Text))
            {
                BooksStorage.AddBookToStorage(new Book(textBox3.Font, textBox3.ForeColor.Name, GenerateBookId(), textBox1.Text, textBox2.Text, textBox3.Text), listBox1);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3) return;
            if (textBox2.Text.Length < 3) return;
            if (textBox3.Text.Length < 3) return;
            if (listBox1.SelectedItem == null) return;
            int bookindex = listBox1.SelectedIndex;
            BooksStorage.Books[bookindex].font = textBox3.Font;
            BooksStorage.Books[bookindex].Title = textBox1.Text;
            BooksStorage.Books[bookindex].Author = textBox2.Text;
            BooksStorage.Books[bookindex].Text = textBox3.Text;
            BooksStorage.Books[bookindex].TextColor = textBox3.ForeColor.Name;
            BooksStorage.EditBookToStorage(BooksStorage.Books[bookindex], listBox1);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        private void button3_Click_3(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            BooksStorage.RemoveBookToStorage(BooksStorage.Books[listBox1.SelectedIndex], listBox1);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private Color GetBookColor()
        {
            Color color = Color.Black;
            switch (BooksStorage.Books[listBox1.SelectedIndex].TextColor)
            {
                case "White":
                    color = Color.White;
                    break;
                case "Yellow":
                    color = Color.Yellow;
                    break;
                case "Orange":
                    color = Color.Orange;
                    break;
                case "Green":
                    color = Color.Green;
                    break;
                case "Blue":
                    color = Color.Blue;
                    break;
                case "Gray":
                    color = Color.Gray;
                    break;
                case "Red":
                    color = Color.Red;
                    break;
                case "Pink":
                    color = Color.Pink;
                    break;
                case "Purple":
                    color = Color.Purple;
                    break;
                case "Black":
                    color = Color.Black;
                    break;
            }
            return color;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            textBox3.ForeColor = GetBookColor();
            textBox1.Text = BooksStorage.Books[listBox1.SelectedIndex].Title;
            textBox2.Text = BooksStorage.Books[listBox1.SelectedIndex].Author;
            textBox3.Text = BooksStorage.Books[listBox1.SelectedIndex].Text;
            textBox3.Font = BooksStorage.Books[listBox1.SelectedIndex].font;

        }

        private void импортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            string[] SBooks = new string[0];
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            if (!File.Exists(filename)) return;
            try
            {
                SBooks = File.ReadAllLines(filename);
            }
            catch
            {
                MessageBox.Show("Нет доступа");
            }

            // добавление книг в хранилище;
            for (int i = 0; i < SBooks.Length; i++)
            {
                string[] temp = SBooks[i].Split(';');
                Book book = new Book(new Font(temp[0], int.Parse(temp[1])), temp[2], GenerateBookId(), temp[3], temp[4], temp[5]);
                if (!BookExistInStorage(book.Title))
                    BooksStorage.AddBookToStorage(book, listBox1);

            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            string[] SBooks = new string[BooksStorage.Books.Count];
            for (int i = 0; i < BooksStorage.Books.Count; i++)
            {
                SBooks[i] = BooksStorage.Books[i].ToSaveBook();
            }
            saveFileDialog1.FileName = filename;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            filename = saveFileDialog1.FileName;     // получаем выбранный файл
            File.WriteAllLines(filename, SBooks);
            MessageBox.Show(filename + " Файл сохранен");
        }

        private void очиститьХранилищеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (; BooksStorage.Books.Count > 0;)
            {
                BooksStorage.RemoveBookToStorage(BooksStorage.Books[0], listBox1);
            }
        }
        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;
        }

        private void жёлтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Yellow;
        }

        private void оранжевыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Orange;
        }

        private void зелёныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Green;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Blue;
        }

        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Gray;
        }

        private void крастыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Red;
        }

        private void розовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Pink;
        }

        private void фиолетовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Purple;
        }
        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
        }

        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextStyle = "Microsoft Sans Serif";
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextStyle = "Bold";
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextStyle = "Times New Roman";
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TextSize = 10;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TextSize = 12;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TextSize = 14;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            TextSize = 16;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            TextSize = 18;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            TextSize = 20;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            TextSize = 22;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            TextSize = 24;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            TextSize = 26;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            TextSize = 28;
            textBox3.Font = new Font(TextStyle, TextSize);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            TextSize = 30;
            textBox3.Font = new Font(TextStyle, TextSize);
        }
    }
}
