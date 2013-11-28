using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3B
{
    public partial class SearchForm : Form
    {
        bookstoreEntities1 bookEntity;
        
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
            SearchResult searchResult = new SearchResult();

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
                        searchResultControl searchResultControl = new searchResultControl();
                        searchResultControl.bookLbl.Text = b.title;
                        var author =  (from a in bookEntity.authors where a.bookid == b.bookid select a.fname + a.lname);
                        searchResultControl.byLabel.Text = author.FirstOrDefault();
                        searchResultControl.publisherLabel.Text = b.publisher;
                        searchResultControl.isbnLabel.Text = b.bookid;
                        searchResultControl.priceLbl.Text = "$" + b.price;
                        searchResult.panel1.Controls.Add(searchResultControl);

                    }

                    
                }

                if (searchInLstBox.SelectedItem.ToString().ToLower().Equals("author"))
                {
                    var category = categoryCmbBox.SelectedItem.ToString();
                    var categoryID = from s in bookEntity.categories where s.categoryname == category select s.categoryid;
                    var author = searchTxtBox.Text;
                    var bookIdList = from a in bookEntity.authors where (a.fname + a.lname).Contains(author) select a.bookid;


                }

                searchResult.Show();
                this.Hide();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
            }


            


        }

       
    }
}
