using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdersBL.Model;

namespace OrdersUI
{
    public partial class Main : Form
    {
        private OrdersContext db;
        private Cart cart;
        private Seller seller;
        private Customer customer;
        private Check check;
        private Sell sell;
        private List<Product> chosenProducts;

        public Main()
        {
            InitializeComponent();
            db = new OrdersContext();
            cart = new Cart(customer);
            seller = new Seller();
            check = new Check();
            sell = new Sell();
            chosenProducts = new List<Product>();
            comboBox1.Items.AddRange(db.Sellers.ToArray());
        }
        

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        private void OrdersLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks, db);
            catalogCheck.Show();
        }

        private void addSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            if (sellerForm.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(sellerForm.Seller);
                db.SaveChanges();
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(productForm.Product);
                db.SaveChanges();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seller.Name = comboBox1.SelectedItem.ToString();
            check.Seller = seller;
            sell.Check = check;
        }

        private void productsChoosingButton_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                ProductChoosingForm productChoosingForm = new ProductChoosingForm(customer);
                if (productChoosingForm.ShowDialog() != DialogResult.OK)
                {
                    List<Product> products = new List<Product>();
                    products = productChoosingForm.Cart.GetAll();
                    foreach (var product in products)
                    {
                        chosenProducts.Add(product);
                        productsListBox.Items.Add(product.Name);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Авторизуйтесь пожалуйста!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            Check check = new Check()
            {
                SellerId = this.seller.SellerId,
                Seller = this.seller,
                CustomerId = cart.Customer.CustomerId,
                Customer = cart.Customer,
                Created = DateTime.Now
            };
            db.Checks.Add(check);
            db.SaveChanges();
            productsListBox.Items.Clear();
        }

        private void logInLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
            if (logInForm.DialogResult == DialogResult.OK)
            {
                var tempCustomer = db.Customers.FirstOrDefault(c => c.Name.Equals(logInForm.Customer.Name));
                if (tempCustomer != null)
                {
                    customer = tempCustomer;
                }
                else
                {
                    db.Customers.Add(logInForm.Customer);
                    db.SaveChanges();
                    customer = logInForm.Customer;
                }
                cart.Customer = customer;
            }
            if (customer != null)
            {
                logInLinkLabel1.Text = $"Добро пожаловать, {customer.Name}!";
                logInLinkLabel1.Location = new Point()
                {
                    X = this.Width - logInLinkLabel1.Width - 30,
                    Y = 38
                };
            }
        }

    }
}
