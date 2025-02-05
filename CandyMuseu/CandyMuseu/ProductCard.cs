using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyMuseu
{
    public partial class ProductCard : Form
    {
        private Product product;
        public ProductCard(Product product)
        {
            InitializeComponent();
            this.product = product;
            if(product.Name != string.Empty )
            {
                textBox1.Text = product.Name;
            }
            if(product.Producer != string.Empty )
            {
                SelectProducer(product.Producer);
            }
            if(product.Price >= 0)
            {
                numericUpDown2.Value = product.Price;
            }
            if(product.Count >= 0)
            {
                numericUpDown1.Value = product.Count;
            }
        }
        private void SelectProducer(string producer)
        {
            if(radioButton1.Text == producer)
            {
                radioButton1.Checked = true;
            }
            if (radioButton2.Text == producer)
            {
                radioButton2.Checked = true;
            }
            if (radioButton3.Text == producer)
            {
                radioButton3.Checked = true;
            }
            if (radioButton4.Text == producer)
            {
                radioButton4.Checked = true;
            }
        }
        private string ProducerSelected()
        {
            string producer = "Uncknow";
            if (radioButton1.Checked)
            {
                producer = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                producer = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                producer = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                producer = radioButton4.Text;
            }
            return producer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                return;
            }
            else if (textBox1.Text[0] == ' ')
            {
                return;
            }
            product.Name = textBox1.Text;
            product.Producer = ProducerSelected();
            product.Price = numericUpDown2.Value;
            product.Count = (int)numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
