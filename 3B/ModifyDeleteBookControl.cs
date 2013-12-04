using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _3B
{
    public partial class ModifyDeleteBookControl : UserControl
    {
        private book bookItem;

        private bookstoreEntities1 bookstoreEntities1;

        public book BookItem
        {
            get { return bookItem; }
            set { bookItem = value; }
        }

        public ModifyDeleteBookControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ShoppingCartData shoppingCart = ShoppingCartData.getInstance();
            //ShoppingCartData.BookListing bookListing = new ShoppingCartData.BookListing();
            //bookListing.Book = bookItem;
            //bookListing.BookQuantity = 1;
            //shoppingCart.BookLsListings.Add(bookListing);
            //this.deleteBtn.Enabled = false;
            //SearchResult.INSTANCE.GetTotalItems();

            try
            {
                bookstoreEntities1 = new bookstoreEntities1();
                var bookLabel = bookLbl.Text;
                bookstoreEntities1.books.FirstOrDefault(b => b.title == bookLabel).deleted = true;
                bookstoreEntities1.SaveChanges();
                deletedLbl.Visible = true;
                deleteBtn.Enabled = false;

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.StackTrace);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BookReview bookReview = BookReview.getInstance();
            //bookLbl.Text = bookItem.title;

            //bookReview.reviewPanel.Controls.Clear();

            //var result = bookstoreEntities1.reviews.Where(b => b.bookid == bookItem.bookid);

            //foreach (var review in result)
            //{
            //    TextBox textBox = new TextBox();
            //    textBox.Text = review.review1;
            //    textBox.ReadOnly = true;
            //    bookReview.reviewPanel.Controls.Add(textBox);
            //}

            //bookReview.ShowDialog();

            var updateBook = new UpdateBook();

            try
            {
                var bookTitle = bookLbl.Text;

                bookstoreEntities1 = new bookstoreEntities1();
                updateBook.tableLayoutPanel1 = new TableLayoutPanel();
                updateBook.tableLayoutPanel2 = new TableLayoutPanel();

                var book = bookstoreEntities1.books.FirstOrDefault(b => b.title.Equals(bookTitle));
                var authors = bookstoreEntities1.authors.Where(a => a.bookid == book.bookid);
                var reviews = bookstoreEntities1.reviews.Where(r => r.bookid == book.bookid);
                var categories = bookstoreEntities1.categories;

                updateBook.ISBNTextbox.Text = book.bookid;
                updateBook.statusTextBox.Text = book.deleted == true ? "Deleted" : "Active";
                updateBook.reactivateButton.Enabled = book.deleted == true;
                updateBook.deleted = book.deleted == true;
                updateBook.titleTextBox.Text = book.title;
                updateBook.publisherTextBox.Text = book.publisher;
                updateBook.yearTextBox.Text = book.year.ToString();
                updateBook.qtyTextBox.Text = book.quantity.ToString();
                updateBook.minQtyTextBox.Text = book.minquantity.ToString();
                updateBook.PriceTextBox.Text = "$" + book.price;

                foreach (var category in categories)
                {
                    updateBook.categoryComboBox.Items.Add(category.categoryname);
                }

                //updateBook.categoryComboBox.SelectedText =
                //    bookstoreEntities1.categories.Where(c => c.categoryid == book.categoryid)
                //        .Select(c => c.categoryname).FirstOrDefault();

                updateBook.categoryComboBox.SelectedIndex =
                    updateBook.categoryComboBox.Items.IndexOf(
                        bookstoreEntities1.categories.Where(c => c.categoryid == book.categoryid)
                            .Select(c => c.categoryname).FirstOrDefault());
                int i = 0;
                foreach (var author in authors)
                {
                    var insertBookControlAuthor = new InsertBookControl_Author();
                    insertBookControlAuthor.authorFnameTxt.Text = author.fname;
                    insertBookControlAuthor.authorLnameTxt.Text = author.lname;
                    updateBook.tableLayoutPanel1.Controls.Add(insertBookControlAuthor,0,i++);
                }

                if (authors.Count() > 1)
                {
                    updateBook.fewerAuthorButton.Enabled = true;
                }

                foreach (var review in reviews)
                {
                    var textBox = new TextBox();
                    textBox.Text = review.review1;
                    textBox.Size = new Size(350,26);
                    updateBook.tableLayoutPanel2.Controls.Add(textBox,0,i++);
                }

                if (reviews.Count() > 1)
                {
                    updateBook.fewerReviewsButton.Enabled = true;
                }

              //  updateBook.tableLayoutPanel1 = new TableLayoutPanel();
                updateBook.tableLayoutPanel1.Location = new Point(129, 98);
                updateBook.tableLayoutPanel1.Size = new Size(369, 82);
                updateBook.tableLayoutPanel1.Dock = DockStyle.Fill;
                updateBook.tableLayoutPanel1.AutoSize = false;
                updateBook.tableLayoutPanel1.AutoScroll = true;
                updateBook.tableLayoutPanel1.Name = "tableLayoutPanel1";
                updateBook.tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

             //   updateBook.tableLayoutPanel2 = new TableLayoutPanel();
                updateBook.tableLayoutPanel2.Location = new Point(129, 313);
                updateBook.tableLayoutPanel2.Size = new Size(369, 111);
                updateBook.tableLayoutPanel2.Dock = DockStyle.Fill;
                updateBook.tableLayoutPanel2.AutoSize = false;
                updateBook.tableLayoutPanel2.AutoScroll = true;
                updateBook.tableLayoutPanel2.Name = "tableLayoutPanel2";
                updateBook.tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

                updateBook.panel1.Controls.Add(updateBook.tableLayoutPanel1);
                updateBook.panel2.Controls.Add(updateBook.tableLayoutPanel2);
                updateBook.Show();
                this .Hide();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.StackTrace);
            }

        }

        private void searchResultControl_Load(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();
        }

    }
}
