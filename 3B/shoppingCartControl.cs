using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3B
{
    public partial class shoppingCartControl : UserControl
    {
        private bookstoreEntities1 bookstoreEntities1;

        public shoppingCartControl()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = ShoppingCart.getInstance();
            shoppingCart.shoppingCartControls.Remove(this);
            shoppingCart.UpdateDisplay();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var label = bookLabel.Text;
            var result = bookstoreEntities1.books.Where(b => b.title.Contains(label)).Select(b => b.quantity).FirstOrDefault();
            if (result != null && int.Parse(textBox1.Text) > (int) result)
            {
                MessageBox.Show("Available quantity: " + result);
                return;
            }
            this.quantityPriceLabel.Text = (Double.Parse(priceLabel.Text)*result).ToString();
            
        }

        private void shoppingCartControl_Load(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();
        }
    }
}
