using OrdersBL.Model;
using System;
using System.Windows.Forms;

namespace OrdersUI
{
    public partial class LogInForm : Form
    {
        public Customer Customer { get; set; }

        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Customer = new Customer()
            {
                Name = textBox1.Text,
            };
            DialogResult = DialogResult.OK;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
