using System;
using System.Windows.Forms;
using OrdersBL.Model;


namespace OrdersUI
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            Product = product ?? new Product();
            textBox1.Text = Product.Name;
            numericUpDown1.Value = Product.Price;
            numericUpDown2.Value = Product.Count;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Product = Product ?? new Product();
            Product.Name = textBox1.Text;
            Product.Price = numericUpDown1.Value;
            Product.Count = (int)numericUpDown2.Value;
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
