using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdersBL.Model;
using System.Text.RegularExpressions;

namespace OrdersUI
{
    public partial class ProductChoosingForm : Form
    {
        OrdersContext db;
        Customer customer;
        
        public Cart Cart { get; set; }

        public ProductChoosingForm()
        {
            InitializeComponent();
            db = new OrdersContext();
            Cart = new Cart(customer);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            MessageBox.Show("Сумма: " + Cart.Amount, "Товары выбраны успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cart = new Cart(customer);
            this.Close();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem is Product product)
            {
                Cart.Add(product);
                listBox2.Items.Add(product);
                UpdateLists();
            }
        }

        private void UpdateLists()
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(Cart.GetAll().ToArray());
            label1.Text = $"Итого: {Cart.Amount}";
        }

        private void ProductChoosingForm_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        private void LoadAllProducts()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text=="")
            {
                LoadAllProducts();
            }
            else
            {
                Task.Run(() =>
                {
                    listBox1?.Invoke((Action)delegate
                    {
                        listBox1.Items.AddRange(db.Products.Where(p => p.Name.ToUpper().StartsWith(textBox1.Text.ToUpper())).ToArray());
                        UpdateLists();
                    });
                });
            }
        }
    }
}
