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

namespace CandyMuseu
{
    public partial class StorageControlWindow : Form
    {

        public StorageControlWindow()
        {
            InitializeComponent();
            listBox1.Items.AddRange(Storage.GetProducts().ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            ProductCard productCard = new ProductCard(product);
            if (productCard.ShowDialog() == DialogResult.OK)
            {
                Storage.Products.Add(product);
                listBox1.Items.Add(Storage.GetProducts()[Storage.GetProducts().Count - 1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Product product = listBox1.SelectedItem as Product;
            ProductCard productCard = new ProductCard(product);
            if (productCard.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Remove(product);
                listBox1.Items.Add(product);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Storage.Products.Remove(listBox1.SelectedItem as Product);
            listBox1.Items.Remove(listBox1.SelectedItem as Product);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
