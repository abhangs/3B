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
    public partial class SearchForm : Form
    {
        bookstoreEntities1 bookEntity;

        public static SearchForm INSTANCE;

        public static SearchForm getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new SearchForm();
            return INSTANCE;
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            bookEntity = new bookstoreEntities1();

            this.searchInLstBox.Items.Add("Keyword anywhere");
            this.searchInLstBox.Items.Add("Title");
            this.searchInLstBox.Items.Add("Author");
            this.searchInLstBox.Items.Add("Publisher");
            this.searchInLstBox.Items.Add("ISBN");


            var categories = from c in bookEntity.categories select c.categoryname;

            foreach (string categoryName in categories)
            {
                this.categoryCmbBox.Items.Add(categoryName);
            }

            categoryCmbBox.SelectedIndex = 0;

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchResult searchResult = SearchResult.getInstance();
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();

           searchResult.panel1.Controls.Clear();
            
            int i = 0;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Clear();

            try
            {
                if (searchInLstBox.SelectedItem.ToString().ToLower().Equals("title"))
                {
                    var category = categoryCmbBox.SelectedItem.ToString();
                    var categoryID = from s in bookEntity.categories where s.categoryname == category select s.categoryid;
                    var title = searchTxtBox.Text;
                    var result = from b in bookEntity.books
                                 where b.title.Contains(title) && b.categoryid == categoryID.FirstOrDefault()
                                 select b;


                    foreach (book b in result)
                    {
                        if (b.deleted!=true && b.quantity >0)
                        {
                            
                            stringBuilder.Clear();
                            var searchResultControl = new SearchResultControl();
                            searchResultControl.bookLbl.Text = b.title;
                            var authorList = (from a in bookEntity.authors where a.bookid.Contains(b.bookid) select a);
                            if (authorList.FirstOrDefault() != null)
                                foreach (author a in authorList)
                                    stringBuilder.Append(a.fname + a.lname + " ");
                            searchResultControl.byLabel.Text = stringBuilder.ToString();
                            searchResultControl.publisherLabel.Text = b.publisher;
                            searchResultControl.isbnLabel.Text = b.bookid;
                            searchResultControl.priceLbl.Text = "$" + b.price;
                            searchResultControl.BookItem = b;
                            tableLayoutPanel1.Controls.Add(searchResultControl, 0, i++);
                            
                        }
                       

                    }


                }

                if (searchInLstBox.SelectedItem.ToString().ToLower().Equals("author"))
                {
                    var category = categoryCmbBox.SelectedItem.ToString();
                    var categoryID = from s in bookEntity.categories where s.categoryname == category select s.categoryid;
                    var author1 = searchTxtBox.Text;
                    var bookIdList = from a in bookEntity.authors where (a.fname + a.lname).Contains(author1) select a.bookid;

                    var result = from b in bookEntity.books where bookIdList.Contains(b.bookid) && b.categoryid == categoryID.FirstOrDefault() select b;

                    foreach (book b in result)
                    {
                        if (b.deleted != true && b.quantity > 0)
                        {
                            stringBuilder.Clear();
                            var searchResultControl = new SearchResultControl();
                            searchResultControl.bookLbl.Text = b.title;
                            var authorList = (from a in bookEntity.authors where a.bookid.Contains(b.bookid) select a);
                            if (authorList.FirstOrDefault() != null) foreach (author a in authorList)
                                    stringBuilder.Append(a.fname + a.lname + " ");
                            searchResultControl.byLabel.Text = stringBuilder.ToString();
                            searchResultControl.publisherLabel.Text = b.publisher;
                            searchResultControl.isbnLabel.Text = b.bookid;
                            searchResultControl.priceLbl.Text = "$" + b.price;
                            searchResultControl.BookItem = b;
                            tableLayoutPanel1.Controls.Add(searchResultControl, 0, i++); 
                        }
                    }

                }

                if (searchInLstBox.SelectedItem.ToString().ToLower().Equals("publisher"))
                {
                    var category = categoryCmbBox.SelectedItem.ToString();
                    var categoryID = from s in bookEntity.categories where s.categoryname == category select s.categoryid;
                    var publisher = searchTxtBox.Text;
                    var result = from b in bookEntity.books where b.publisher.Contains(publisher) && b.categoryid == categoryID.FirstOrDefault() select b;

                    foreach (book b in result)
                    {
                        if (b.deleted != true && b.quantity > 0)
                        {
                            stringBuilder.Clear();
                            var searchResultControl = new SearchResultControl();
                            searchResultControl.bookLbl.Text = b.title;
                            var authorList = (from a in bookEntity.authors where a.bookid.Contains(b.bookid) select a);
                            if (authorList.FirstOrDefault() != null) foreach (author a in authorList)
                                    stringBuilder.Append(a.fname + a.lname + " ");

                            searchResultControl.byLabel.Text = stringBuilder.ToString();
                            searchResultControl.publisherLabel.Text = b.publisher;
                            searchResultControl.isbnLabel.Text = b.bookid;
                            searchResultControl.priceLbl.Text = "$" + b.price;
                            searchResultControl.BookItem = b;
                            tableLayoutPanel1.Controls.Add(searchResultControl, 0, i++); 
                        }

                    }

                }

                if (searchInLstBox.SelectedItem.ToString().ToLower().Equals("isbn"))
                {
                    var category = categoryCmbBox.SelectedItem.ToString();
                    var categoryID = from s in bookEntity.categories where s.categoryname == category select s.categoryid;
                    var isbn = searchTxtBox.Text;
                    var result = from b in bookEntity.books where b.bookid.Contains(isbn) && b.categoryid == categoryID.FirstOrDefault() select b;

                    foreach (book b in result)
                    {
                        if (b.deleted != true && b.quantity > 0)
                        {
                            stringBuilder.Clear();
                            var searchResultControl = new SearchResultControl();
                            searchResultControl.bookLbl.Text = b.title;
                            var authorList = (from a in bookEntity.authors where a.bookid.Contains(b.bookid) select a);
                            if (authorList.FirstOrDefault() != null) foreach (author a in authorList)
                                    stringBuilder.Append(a.fname + a.lname + " ");
                            stringBuilder.Remove(stringBuilder.Capacity - 1, 1);
                            searchResultControl.byLabel.Text = stringBuilder.ToString();
                            searchResultControl.publisherLabel.Text = b.publisher;
                            searchResultControl.isbnLabel.Text = b.bookid;
                            searchResultControl.priceLbl.Text = "$" + b.price;
                            searchResultControl.BookItem = b;
                            tableLayoutPanel1.Controls.Add(searchResultControl, 0, i++); ;
                            
                        }
                    }
                }

                if (searchInLstBox.SelectedItem.ToString().ToLower().Equals("keyword anywhere"))
                {
                    var category = categoryCmbBox.SelectedItem.ToString();
                    var categoryID = from s in bookEntity.categories where s.categoryname == category select s.categoryid;

                    var title = searchTxtBox.Text;

                    var author1 = searchTxtBox.Text;
                    var bookIdList = from a in bookEntity.authors where (a.fname + a.lname).Contains(author1) select a.bookid;

                    var publisher = searchTxtBox.Text;

                    var isbn = searchTxtBox.Text;

                    var result = from b in bookEntity.books
                                 where b.title.Contains(title) || bookIdList.Contains(b.bookid)
                                     || b.publisher.Contains(publisher) || b.bookid.Contains(isbn) && b.categoryid == categoryID.FirstOrDefault()
                                 select b;

                    foreach (book b in result)
                    {
                        if (b.deleted != true && b.quantity > 0)
                        {
                            stringBuilder.Clear();
                            var searchResultControl = new SearchResultControl();
                            searchResultControl.bookLbl.Text = b.title;
                            var authorList = (from a in bookEntity.authors where a.bookid.Contains(b.bookid) select a);
                            if (authorList.FirstOrDefault() != null) foreach (author a in authorList)
                                    stringBuilder.Append(a.fname + a.lname + " ");
                            searchResultControl.byLabel.Text = stringBuilder.ToString();
                            searchResultControl.publisherLabel.Text = b.publisher;
                            searchResultControl.isbnLabel.Text = b.bookid;
                            searchResultControl.priceLbl.Text = "$" + b.price;
                            searchResultControl.BookItem = b;
                            tableLayoutPanel1.Controls.Add(searchResultControl, 0, i++);
                            
                        }
                    }


                }

                tableLayoutPanel1.Location = new Point(12,63);
                tableLayoutPanel1.Size = new Size(750,230);
                tableLayoutPanel1.Dock = DockStyle.Fill;
                tableLayoutPanel1.AutoSize = false;
                tableLayoutPanel1.AutoScroll = true;
                tableLayoutPanel1.Name = "tableLayoutPanel1";
                tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
                searchResult.panel1.Controls.Add(tableLayoutPanel1);

                ShoppingCartData.getInstance().LastCategorySearched = categoryCmbBox.SelectedItem.ToString();
                searchResult.GetTotalItems();
                searchResult.Show();
                this.Hide();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.StackTrace);
                MessageBox.Show("Error searching for a book. Please check input values or contact the administrator",
                    "Error!", MessageBoxButtons.OK);
            }





        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageShpngCartBtn_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = ShoppingCart.getInstance();
            shoppingCart.Show();
            this.Hide();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
