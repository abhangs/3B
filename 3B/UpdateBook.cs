using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _3B
{
    public partial class UpdateBook : Form
    {
        public TableLayoutPanel tableLayoutPanel1;
        public TableLayoutPanel tableLayoutPanel2;
        public bool deleted;
        private bookstoreEntities1 bookstoreEntities1;


        public UpdateBook()
        {
            InitializeComponent();
        }

       

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                bookstoreEntities1 = new bookstoreEntities1();
                book updatedBook = new book();

                var updatedCategory = categoryComboBox.SelectedItem.ToString();

                updatedBook.bookid = ISBNTextbox.Text;
                updatedBook.deleted = deleted;
                updatedBook.title = titleTextBox.Text;
                updatedBook.publisher = publisherTextBox.Text;
                updatedBook.year = short.Parse(yearTextBox.Text);
                updatedBook.minquantity = short.Parse(minQtyTextBox.Text);
                updatedBook.price = double.Parse(PriceTextBox.Text.Replace('$',' '));
                updatedBook.categoryid =
                    bookstoreEntities1.categories.Where(c => c.categoryname == updatedCategory)
                        .Select(c => c.categoryid)
                        .FirstOrDefault();

                var authors = bookstoreEntities1.authors.Where(a => a.bookid == updatedBook.bookid);
                var reviews = bookstoreEntities1.reviews.Where(r => r.bookid == updatedBook.bookid);

                foreach (var author in authors)
                {
                    bookstoreEntities1.authors.Remove(author);
                }

                foreach (var review in reviews)
                {
                    bookstoreEntities1.reviews.Remove(review);
                }

                bookstoreEntities1.SaveChanges();

                foreach (var authorControl in tableLayoutPanel1.Controls)
                {
                    var controlAuthor = (InsertBookControl_Author)authorControl;
                    var fname = controlAuthor.authorFnameTxt.Text;
                    var lname = controlAuthor.authorLnameTxt.Text;
                    bookstoreEntities1.authors.Add(new author { bookid = updatedBook.bookid, fname = fname, lname = lname });
                }

                foreach (var reviewControl in tableLayoutPanel2.Controls)
                {
                    var textbox = (TextBox)reviewControl;
                    var reviewText = textbox.Text;
                    bookstoreEntities1.reviews.Add(new review { bookid = updatedBook.bookid, review1 = reviewText });
                }

                bookstoreEntities1.books.AddOrUpdate(updatedBook);

                bookstoreEntities1.SaveChanges();
                MessageBox.Show("Changes saved successfully", "Message", MessageBoxButtons.OK);

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.StackTrace);
            }

        }

        private void moreAuthorsButton_Click(object sender, EventArgs e)
        {
            InsertBookControl_Author insertBookControlAuthor = new InsertBookControl_Author();
            tableLayoutPanel1.Controls.Add(insertBookControlAuthor);
            fewerAuthorButton.Enabled = true;
            Refresh();
        }

        private void fewerAuthorButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
            if (tableLayoutPanel1.Controls.Count == 1)
                fewerAuthorButton.Enabled = false;
            Refresh();
            
        }

        private void moreReviewsButton_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Size = new Size(350, 26);
            tableLayoutPanel2.Controls.Add(textBox);
            fewerReviewsButton.Enabled = true;
            Refresh();
        }

        private void fewerReviewsButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.RemoveAt(tableLayoutPanel2.Controls.Count - 1);
            if (tableLayoutPanel2.Controls.Count == 1)
                fewerReviewsButton.Enabled = false;
            Refresh();
        }

        private void reactivateButton_Click(object sender, EventArgs e)
        {
            this.statusTextBox.Text = "Active";
            deleted = false;
        }

        private void UpdateBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
           
            ManageBookstoreCatalog manageBookstoreCatalog = new ManageBookstoreCatalog();
            manageBookstoreCatalog.Show();
            this.Hide();
        }
    }
}
