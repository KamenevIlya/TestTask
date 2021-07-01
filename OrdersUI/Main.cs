using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdersBL.Model;

namespace OrdersUI
{
    public partial class Main : Form
    {
        OrdersContext db;
        Cart cart;
        Customer customer;

        public Main()
        {
            InitializeComponent();
            db = new OrdersContext();
            cart = new Cart(customer);
        }

        private void logInLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                logInLabel2.Text = $"Добро пожаловать, {customer.Name}!";
                logInLabel2.Location = new Point()
                {
                    X = this.Width - logInLabel2.Width - 30,
                    Y = 38
                };
            }
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
            Task.Run(() =>
            {
                listBox1?.Invoke((Action)delegate
                {
                    listBox1.Items.AddRange(db.Products.ToArray());
                    UpdateLists();
                });
            });
        }

        private void UpdateLists()
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(cart.GetAll().ToArray());
            label1.Text = $"Итого: {cart.Amount}";
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                listBox2.Items.Clear();
                cart = new Cart(customer);
                MessageBox.Show("Сумма: " + cart.Amount, "Покупка выполнена успешна!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Авторизуйтесь пожалуйста!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem is Product product)
            {
                cart.Add(product);
                listBox2.Items.Add(product);
                UpdateLists();
            }
        }
    }
}
