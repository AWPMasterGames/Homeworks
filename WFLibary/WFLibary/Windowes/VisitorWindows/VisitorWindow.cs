using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFLibary.Windowes
{
    public partial class VisitorWindow : Form
    {
        public VisitorWindow(int userID)
        {
            User user = UserResources.GetListOfUser()[userID];
            InitializeComponent();
            listBox1.Items.AddRange(BooksStorage.GetBooksOfStorage().ToArray());
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
    }
}
