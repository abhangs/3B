using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _3B
{
    public partial class InsertNewBook : Form
    {
        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private bookstoreEntities1 bookstoreEntities1;

        private List<author> authorList;
        private List<review> reviewList;

        public InsertNewBook()
        {
            InitializeComponent();

            authorList = new List<author>();
            reviewList = new List<review>();


            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Location = new Point(12, 63);
            tableLayoutPanel.Size = new Size(750, 230);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.AutoSize = false;
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.Name = "tableLayoutPanel1";
            tableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel2.Location = new Point(12, 63);
            tableLayoutPanel2.Size = new Size(750, 230);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.AutoSize = false;
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.AddRows;





            authorPanel.Controls.Add(tableLayoutPanel);   
            reviewListPanel.Controls.Add(tableLayoutPanel2);
        }

        private void InsertNewBook_Load(object sender, EventArgs e)
        {
            fewerAuthorButton.Enabled = false;
            fewerReviewsButton.Enabled = false;

            tableLayoutPanel.Controls.Add(new InsertBookControl_Author());
            tableLayoutPanel2.Controls.Add(new TextBox());
            
            bookstoreEntities1 = new bookstoreEntities1();
            var categories = bookstoreEntities1.categories;

            foreach (var category in categories)
            {
                categoryComboBox.Items.Add(category.categoryname);
            }

            categoryComboBox.SelectedIndex = 0;

            Refresh();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void moreAuthorsButton_Click(object sender, EventArgs e)
        {
            var newAuthor = new InsertBookControl_Author();
            tableLayoutPanel.Controls.Add(newAuthor);
            fewerAuthorButton.Enabled = true;
            Refresh();
           
        }

        private void fewerAuthorButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel.Controls.RemoveAt(tableLayoutPanel.Controls.Count-1);
            if (tableLayoutPanel.Controls.Count == 1)
                fewerAuthorButton.Enabled = false;
            Refresh();
            
        }

        private void moreReviewsButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Add(new TextBox());
            fewerReviewsButton.Enabled = true;
            Refresh();
        }

        private void fewerReviewsButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.RemoveAt(tableLayoutPanel2.Controls.Count -1);
           if (tableLayoutPanel2.Controls.Count == 1)
                fewerReviewsButton.Enabled = false;
            Refresh();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();
            book newBook =  new book();
            
            try
            {
                newBook.bookid = ISBNTextbox.Text;
                newBook.title = titleTextBox.Text;
                newBook.publisher = publisherTextBox.Text;
                newBook.year =short.Parse(yearTextBox.Text);
                newBook.price = double.Parse(PriceTextBox.Text);
                newBook.minquantity = short.Parse(minQtyTextBox.Text);

                var category = categoryComboBox.SelectedItem.ToString();
                var categoryId = bookstoreEntities1.categories.Where(c => c.categoryname.Contains(category));
                var firstOrDefault = categoryId.FirstOrDefault();
                if (firstOrDefault != null) newBook.categoryid = firstOrDefault.categoryid;

                foreach (var authorControl in tableLayoutPanel.Controls)
                {
                   InsertBookControl_Author authorInsertBookControlAuthor = (InsertBookControl_Author) authorControl;
                   author author = new author { bookid = newBook.bookid, fname = authorInsertBookControlAuthor.authorFnameTxt.Text, lname = authorInsertBookControlAuthor.authorLnameTxt.Text };
                   bookstoreEntities1.authors.Add(author);
                }

                foreach (var reviewControl in tableLayoutPanel2.Controls)
                {
                    TextBox review = (TextBox) reviewControl;
                    review newReview =  new review{bookid = newBook.bookid, review1 = review.Text};
                    bookstoreEntities1.reviews.Add(newReview);
                }

                 bookstoreEntities1.books.Add(newBook);

                bookstoreEntities1.SaveChanges();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.StackTrace);
            }
        }
    }
}
