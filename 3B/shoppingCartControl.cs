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

        private ShoppingCartData.BookListing book;

        public shoppingCartControl()
        {
            InitializeComponent();
        }

        public ShoppingCartData.BookListing Book
        {
            get { return book; }
            set { book = value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ShoppingCartData shoppingCartData = ShoppingCartData.getInstance();
                shoppingCartData.BookLsListings.Remove(book);
                ShoppingCart shoppingCart = ShoppingCart.getInstance();
                shoppingCart.shoppingCartControls.Remove(this);
                shoppingCart.UpdateDisplay();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a;
            try
            {
                if(int.TryParse(textBox1.Text,out a))
                {

                    bookstoreEntities1 = new bookstoreEntities1();
                    var label = bookLabel.Text;
                    var result = bookstoreEntities1.books.FirstOrDefault(b => b.title.Contains(label));
                    if (result != null && int.Parse(textBox1.Text) > (int)result.quantity)
                    {
                        MessageBox.Show("Available quantity: " + result.quantity);
                        return;
                    }

                    ShoppingCartData shoppingCartData = ShoppingCartData.getInstance();

                    foreach (var bookLsListing in shoppingCartData.BookLsListings)
                    {
                        if (bookLsListing.Book == book.Book)
                        {
                            bookLsListing.BookQuantity = int.Parse(a.ToString());
                        }
                    }

                    var quantityPrice = (result.price)*int.Parse(textBox1.Text);
                    quantityPriceLabel.Text = "$" + quantityPrice;

                }
            }
            catch (Exception exception)
            {
                
                
            }
        }

        private void shoppingCartControl_Load(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();
        }
    }
}
