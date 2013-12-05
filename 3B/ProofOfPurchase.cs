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
    public partial class ProofOfPurchase : Form
    {
        

        public ProofOfPurchase()
        {
            InitializeComponent();
        }

        private void ProofOfPurchase_Load(object sender, EventArgs e)
        {
            var bookstoreEntities1 = new bookstoreEntities1();

            TableLayoutPanel tableLayout = new TableLayoutPanel();

            ShoppingCartData.getInstance().getCustomerData();
            customerNameLbl.Text = ShoppingCartData.getInstance().Customer.fname + " " +
                                   ShoppingCartData.getInstance().Customer.lname;
            streetAddressLbl.Text = ShoppingCartData.getInstance().Customer.address;
            cityLabel.Text = ShoppingCartData.getInstance().Customer.city;
            stateLbl.Text = ShoppingCartData.getInstance().Customer.state;
            zipLbl.Text = ShoppingCartData.getInstance().Customer.zip.ToString();

         

            var username = ShoppingCartData.getInstance().UserName;
            var result =
                bookstoreEntities1.customers.Where(c => c.username.Equals(username)).Select(c => c.creditcardnumber);
            if (result.FirstOrDefault() != null)
            {
                cardInfoLbl.Text = result.FirstOrDefault();
            }
          
            double subTotal = 0;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var bookOrder in ShoppingCartData.getInstance().BookLsListings)
            {
                stringBuilder.Clear();
                confirmOrderControl confirmOrderControl = new confirmOrderControl();
                confirmOrderControl.bookTitleLbl.Text = bookOrder.Book.title;
                var authors = bookstoreEntities1.authors.Where(a => a.bookid == bookOrder.Book.bookid);
                if (authors.FirstOrDefault() != null)
                    foreach (var author in authors)
                    {
                        stringBuilder.Append(author.fname + " " + author.lname + " ");
                    }
                confirmOrderControl.byLabel.Text = stringBuilder.ToString();
                confirmOrderControl.priceLbl.Text = "$" + bookOrder.Book.price;
                confirmOrderControl.quantityLbl.Text = bookOrder.BookQuantity.ToString();
                confirmOrderControl.quantityPriceLbl.Text = "$" + (bookOrder.BookQuantity * bookOrder.Book.price);
                subTotal = subTotal + double.Parse(confirmOrderControl.quantityPriceLbl.Text.Replace('$',' '));
                tableLayout.Controls.Add(confirmOrderControl);
            }

            tableLayout.Location = new Point(12, 63);
            tableLayout.Size = new Size(750, 230);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.AutoSize = false;
            tableLayout.AutoScroll = true;
            tableLayout.Name = "tableLayoutPanel1";
            tableLayout.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            orderListPanel.Controls.Add(tableLayout);

            subTotalLbl.Text = "$" + subTotal;
            shippingHandlingLbl.Text = "$4.00";
            totalLbl.Text = "$" + subTotal + 4;

            userIDLbl.Text = username;
            dateLbl.Text = DateTime.Now.ToShortDateString();
            timeLbl.Text = DateTime.Now.ToShortTimeString();

        }

        private void newSearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = SearchForm.getInstance();
            ShoppingCartData shoppingCartData = ShoppingCartData.getInstance();
            shoppingCartData.BookLsListings.Clear();
            searchForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProofOfPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      

       
       
    }
}
