using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iName = textBox1.Text;
            double price = Convert.ToDouble(textBox3.Text);
            double discount = Convert.ToDouble(textBox2.Text);
            int quantity = Convert.ToInt32(textBox4.Text);
            
            DiscountedItem dItem = new DiscountedItem (iName, price, quantity, discount);
            label6.Text = dItem.getTotalPrice().ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string iName = textBox1.Text;
            double price, discount;
            price = Convert.ToDouble(textBox3.Text);
            discount = Convert.ToDouble(textBox2.Text);
            int quantity = Convert.ToInt32(textBox4.Text);

            DiscountedItem dItem = new DiscountedItem(iName, price, quantity, discount);
            dItem.setPayment(Convert.ToDouble(textBox5.Text));
            label9.Text = dItem.getChange().ToString();
        }
        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {
        }
    }
}
