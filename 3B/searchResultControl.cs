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
    public partial class SearchResultControl : UserControl
    {
        private book bookItem;

        private bookstoreEntities1 bookstoreEntities1;

        public book BookItem
        {
            get { return bookItem; }
            set { bookItem = value; }
        }

        public SearchResultControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShoppingCartData shoppingCart = ShoppingCartData.getInstance();
            ShoppingCartData.BookListing bookListing = new ShoppingCartData.BookListing();
            bookListing.Book = bookItem;
            bookListing.BookQuantity = 1;
            shoppingCart.BookLsListings.Add(bookListing);
            this.button1.Enabled = false;
            SearchResult.getInstance().GetTotalItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookReview bookReview = BookReview.getInstance();
            bookLbl.Text = bookItem.title;

            bookReview.reviewPanel.Controls.Clear();

            var result = bookstoreEntities1.reviews.Where(b => b.bookid == bookItem.bookid);

            foreach (var review in result)
            {
                TextBox textBox = new TextBox();
                textBox.Text = review.review1;
                textBox.ReadOnly = true;
                bookReview.reviewPanel.Controls.Add(textBox);
            }

            bookReview.ShowDialog();


        }

        private void searchResultControl_Load(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();
        }

       
    }
}
