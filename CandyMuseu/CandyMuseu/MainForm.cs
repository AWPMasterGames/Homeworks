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

            LoginWindow loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                this.Visible = false;
                StorageControlWindow storageControlWindow = new StorageControlWindow();
                if (storageControlWindow.ShowDialog() == DialogResult.OK)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(Storage.GetProducts().ToArray());
                    this.Visible = true;
                }
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
        private bool ProductExistIntTSP(string name)
        {
            for(int i = 0; i < TotalSeledProducts.Count; i++)
            {
                if (TotalSeledProducts[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0) return;
            int CBselectItem = comboBox1.SelectedIndex;
            List<Product> products = new List<Product>();
            string sProducts = "";
            TotalSaledCost += CheckCost;
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                products.Add(ProductsIn—heck[checkedListBox1.CheckedIndices[i]]);
                if (ProductExistIntTSP(ProductsIn—heck[checkedListBox1.CheckedIndices[i]].Name))
                {
                    for (int j = 0; j < TotalSeledProducts.Count; j++)
                    {
                        if (TotalSeledProducts[j].Name == ProductsIn—heck[checkedListBox1.CheckedIndices[i]].Name)
                        {
                            TotalSeledProducts[j].Count += ProductsIn—heck[checkedListBox1.CheckedIndices[i]].Count;
                            TotalSeledProducts[j].Price += ProductsIn—heck[checkedListBox1.CheckedIndices[i]].Price;
                        }
                    }
                }
                else
                {
                    TotalSeledProducts.Add(ProductsIn—heck[checkedListBox1.CheckedIndices[i]]);
                }
            }
            for (int i = 0; i < products.Count; i++)
            {
                sProducts += $"{products[i].Name}   {products[i].Count}¯Ú.   {products[i].Price}.\n";
            }
            sProducts += $"\n\n—ÛÏÏ‡ ˜ÂÍ‡: {CheckCost}";
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                for (int j = 0; j < Storage.Products.Count; j++)
                {
                    if (Storage.Products[j].Name == products[checkedListBox1.CheckedIndices[i]].Name)
                    {
                        Storage.Products[j].Count -= products[checkedListBox1.CheckedIndices[i]].Count;
                    }
                }
            }
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Storage.GetProducts().ToArray());
            comboBox1.SelectedIndex = CBselectItem;
            for (int i = checkedListBox1.CheckedIndices.Count; i > 0; i--)
            {

                ProductsIn—heck.RemoveAt(checkedListBox1.CheckedIndices[checkedListBox1.CheckedIndices.Count - 1]);
                checkedListBox1.Items.Remove(checkedListBox1.Items[checkedListBox1.CheckedIndices[checkedListBox1.CheckedIndices.Count - 1]]);
            }
            MessageBox.Show(sProducts);

        }
        private void UpdateCost()
        {
            decimal cost = 0;
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                cost += ProductsIn—heck[checkedListBox1.CheckedIndices[i]].Price;
            }
            CheckCost = cost;
            CostL.Text = $"{cost}.";
        }
        private void checkedListBox1_CheckedIndex(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sProducts = "";
            for(int i = 0; i < TotalSeledProducts.Count; i++)
            {
                sProducts += $"{TotalSeledProducts[i].Name}   {TotalSeledProducts[i].Count}¯Ú.   {TotalSeledProducts[i].Price}.\n";
            }
            sProducts += $"\n\n—ÛÏÏ‡ ˜ÂÍ‡: {TotalSaledCost}";
            TotalSeledProducts.Clear();
            TotalSaledCost = 0;
            MessageBox.Show(sProducts);
        }
    }
}
