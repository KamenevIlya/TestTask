using OrdersBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Customer = new Customer()
            {
                Name = textBox1.Text,
            };
            DialogResult = DialogResult.OK;
        }
    }
}
