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
    public partial class ConfirmOrder : Form
    {
        private bookstoreEntities1 bookstoreEntities1;
        public ConfirmOrder()
        {
            InitializeComponent();
        }

        public static ConfirmOrder INSTANCE;


        internal static ConfirmOrder getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new ConfirmOrder();
            return INSTANCE;
        }

        private void ConfirmOrder_Load(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();

            ShoppingCartData.getInstance().getCustomerData();
            customerNameLbl.Text = ShoppingCartData.getInstance().Customer.fname + " " +
                                   ShoppingCartData.getInstance().Customer.lname;
            streetAddressLbl.Text = ShoppingCartData.getInstance().Customer.address;
            stateLbl.Text = ShoppingCartData.getInstance().Customer.state;
            zipLbl.Text = ShoppingCartData.getInstance().Customer.zip.ToString();

            var username = ShoppingCartData.getInstance().Customer.username;
            var result =
                bookstoreEntities1.customers.Where(c => c.username.Equals(username)).Select(c => c.creditcardnumber);

            useCreditCardRadioBtn.Checked = true;
            if (result.FirstOrDefault() != null)
            {
                creditCardLabel.Text = result.FirstOrDefault();
            }

            newCardRadioBtn.Checked = false;
            cardTypeCmbBox.Enabled = false;
            cardNumberTxtBox.Enabled = false;

            double subTotal = 0;

            foreach (var bookOrder in ShoppingCartData.getInstance().BookLsListings)
            {
                confirmOrderControl confirmOrderControl = new confirmOrderControl();
                confirmOrderControl.bookTitleLbl.Text = bookOrder.Book.title;
                var authors = bookstoreEntities1.authors.Where(a => a.bookid == bookOrder.Book.bookid);
                if(authors.FirstOrDefault()!=null)
                    foreach (var author in authors)
                    {
                        confirmOrderControl.byLabel.Text = confirmOrderControl.byLabel.Text + " " + author.fname + " " +
                                                           author.lname;
                    }
                confirmOrderControl.priceLbl.Text = "$" + bookOrder.Book.price;
                confirmOrderControl.quantityLbl.Text = bookOrder.BookQuantity.ToString();
                confirmOrderControl.quantityPriceLbl.Text = "$" + (bookOrder.BookQuantity*bookOrder.Book.price);
                subTotal = subTotal + double.Parse(confirmOrderControl.quantityPriceLbl.Text);
                orderListPanel.Controls.Add(confirmOrderControl);
            }

            subTotalLbl.Text = "$" + subTotal;
            shippingHandlingLbl.Text = "$4.00";
            totalLbl.Text = "$"+ subTotal + 4;

        }

        private void newCardRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            cardTypeCmbBox.Enabled = true;
            cardNumberTxtBox.Enabled = true;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
           ProofOfPurchase proof = new ProofOfPurchase();
            proof.Show();
            this.Hide();
        }

        private void UpdateCustBtnClick(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();
            custRegisterForm custRegisterForm = new custRegisterForm();
            custRegisterForm.usernameTxtBox.Text = ShoppingCartData.getInstance().UserName;
            custRegisterForm.usernameTxtBox.ReadOnly = true;
            custRegisterForm.btnRegister.Text = "Update";
            custRegisterForm.btnDontRegister.Text = "Cancel";
            custRegisterForm.btnRegister.Click += (o, args) => this.Close();
            custRegisterForm.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            ProofOfPurchase proofOfPurchase = new ProofOfPurchase();
            proofOfPurchase.Show();
            this.Close();
        }



           }
    }

