using System;
using System.Data.Entity;
using System.Windows.Forms;
using OrdersBL.Model;
using System.Collections.Generic;

namespace OrdersUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        OrdersContext db;
        DbSet<T> set;
        public Catalog(DbSet<T> set, OrdersContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;
            if (typeof(T) == typeof(Product))
            {
                var product = set.Find(id) as Product;
                if (product != null)
                {
                    var productForm = new ProductForm(product);
                    if (productForm.ShowDialog() == DialogResult.OK)
                    {
                        product = productForm.Product;
                        db.SaveChanges();
                        dataGridView.Refresh();
                    }
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                var seller = set.Find(id) as Seller;
                if (seller != null)
                {
                    var sellerForm = new SellerForm(seller);
                    if (sellerForm.ShowDialog() == DialogResult.OK)
                    {
                        seller = sellerForm.Seller;
                        db.SaveChanges();
                        dataGridView.Refresh();
                    }
                }
            }
        }
    }
}
