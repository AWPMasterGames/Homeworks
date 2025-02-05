namespace CandyMuseu
{
    public partial class MainForm : Form
    {
        List<Product> TotalSeledProducts = new List<Product>();
        List<Product> ProductsIn—heck = new List<Product>();
        decimal TotalSaledCost = 0;
        decimal CheckCost = 0;
        public MainForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Storage.GetProducts().ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StorageControlWindow storageControlWindow = new StorageControlWindow();
            if (storageControlWindow.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(Storage.GetProducts().ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            else if (numericUpDown1.Value < 1) return;
            Product SelectedProduct = comboBox1.SelectedItem as Product;
            Product product = new Product(SelectedProduct.Name, SelectedProduct.Producer, SelectedProduct.Price, (int)numericUpDown1.Value);
            for (int i = 0; i < ProductsIn—heck.Count; i++)
            {
                if (SelectedProduct.Name == ProductsIn—heck[i].Name)
                {
                    ProductsIn—heck[i].Count += (int)numericUpDown1.Value;
                    ProductsIn—heck[i].Price += product.Price * numericUpDown1.Value;
                    checkedListBox1.Items[i] = $"{ProductsIn—heck[i].Name} * {ProductsIn—heck[i].Count} - {ProductsIn—heck[i].Price}";
                    /*checkedListBox1.Items.RemoveAt(i);
                    checkedListBox1.Items.Insert(i, $"{ProductsIn—heck[i].Name} * {ProductsIn—heck[i].Count} - {ProductsIn—heck[i].Price}");*/
                    UpdateCost();
                    return;
                }
            }
            product.Price = product.Price * numericUpDown1.Value;
            ProductsIn—heck.Add(product);
            checkedListBox1.Items.Add($"{product.Name} * {numericUpDown1.Value} - {product.Price}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            TotalSaledCost += CheckCost;
            for (int i = 0; i < checkedListBox1.SelectedIndices.Count; i++)
            {
                products.Add(ProductsIn—heck[checkedListBox1.SelectedIndices[i]]);
                TotalSeledProducts.Add(ProductsIn—heck[checkedListBox1.SelectedIndices[i]]);
            }
        }
        private void UpdateCost()
        {
            decimal cost = 0;
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                cost += ProductsIn—heck[checkedListBox1.CheckedIndices[i]].Price;
            }
            CheckCost = cost;
            CostL.Text = cost.ToString();
        }
        private void checkedListBox1_CheckedIndex(object sender, EventArgs e)
        {
            UpdateCost();
        }
    }
}
