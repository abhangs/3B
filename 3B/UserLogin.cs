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
    public partial class UserLogin : Form
    {
        private bookstoreEntities1 bookstoreEntities1;
        
        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var username = userNameTxt.Text;
                var pin = pinTxt.Text;

                bookstoreEntities1 = new bookstoreEntities1();
                if ((bookstoreEntities1.customers.Where(c => c.username == username && c.pin == pin)).Any())
                {
                    ShoppingCartData.getInstance().UserName = username;
                    //SearchForm searchForm = SearchForm.getInstance();
                    //searchForm.Show();

                    SearchResult searchResult = SearchResult.getInstance();
                    searchResult.panel1.Controls.Clear();
                    TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();

                    int i = 0;
                    StringBuilder stringBuilder = new StringBuilder();

                    var lastCategory =
                        bookstoreEntities1.customers.Where(c => c.username == username)
                            .Select(c => c.categorylastsearched);

                    if (lastCategory.FirstOrDefault() != null)
                    {
                        var categoryId =
                            bookstoreEntities1.categories.Where(c => c.categoryid == lastCategory.FirstOrDefault()).Select( c => c.categoryid);
                        var result = bookstoreEntities1.books.Where(b => b.categoryid == categoryId.FirstOrDefault());

                        foreach (book b in result)
                        {
                            if (b.deleted != true && b.quantity > 0)
                            {
                                stringBuilder.Clear();
                                var searchResultControl = new SearchResultControl();
                                searchResultControl.bookLbl.Text = b.title;
                                var authorList = (from a in bookstoreEntities1.authors where a.bookid.Contains(b.bookid) select a);
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

                    tableLayoutPanel1.Location = new Point(12, 63);
                    tableLayoutPanel1.Size = new Size(750, 230);
                    tableLayoutPanel1.Dock = DockStyle.Fill;
                    tableLayoutPanel1.AutoSize = false;
                    tableLayoutPanel1.AutoScroll = true;
                    tableLayoutPanel1.Name = "tableLayoutPanel1";
                    tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
                    searchResult.panel1.Controls.Add(tableLayoutPanel1);

                    searchResult.Show();

                    

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pinTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mainForm mnForm = new mainForm();
            mnForm.Show();
            this.Hide();
        }

        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
