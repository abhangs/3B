using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            try
            {
                bookstoreEntities1 = new bookstoreEntities1();

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
                    bookstoreEntities1.customers.Where(c => c.username.Equals(username));

              //  creditCardLabel.Text = result.FirstOrDefault(); 

                useCreditCardRadioBtn.Checked = true;
                if (result.FirstOrDefault() != null)
                {
                     cardNumberTxt.Text = result.FirstOrDefault().creditcardnumber;
                }

                var cardTypes = bookstoreEntities1.creditcardtypes;
                foreach (var creditcardtype in cardTypes)
                {
                    cardTypeCmbBox.Items.Add(creditcardtype.creditcardtype1);
                }
                cardTypeCmbBox.SelectedIndex = 0;

                newCardRadioBtn.Checked = false;
                cardTypeCmbBox.Enabled = false;
                cardNumberTxtBox.Enabled = false;

                double subTotal = 0;

                StringBuilder stringBuilder = new StringBuilder();


                foreach (var bookOrder in ShoppingCartData.getInstance().BookLsListings)
                {
                    stringBuilder.Clear();
                    confirmOrderControl confirmOrderControl = new confirmOrderControl();
                    confirmOrderControl.bookTitleLbl.Text = bookOrder.Book.title;
                    ShoppingCartData.BookListing order = bookOrder;
                    var authors = bookstoreEntities1.authors.Where(a => a.bookid == order.Book.bookid);
                    if (authors.FirstOrDefault() != null)
                        foreach (var author in authors)
                        {
                            stringBuilder.Append(author.fname +" "+ author.lname + "  ");
                        }
                    confirmOrderControl.byLabel.Text = stringBuilder.ToString();
                    confirmOrderControl.priceLbl.Text = "$" + bookOrder.Book.price;
                    confirmOrderControl.quantityLbl.Text = bookOrder.BookQuantity.ToString();
                    confirmOrderControl.quantityPriceLbl.Text = "$" + (bookOrder.BookQuantity * bookOrder.Book.price);
                    subTotal = subTotal + double.Parse(confirmOrderControl.quantityPriceLbl.Text.Replace('$',' '));
                    tableLayout.Controls.Add(confirmOrderControl);
                }

                tableLayout.Location = new Point(12, 63);
                tableLayout.Size = new Size(775, 278);
                tableLayout.Dock = DockStyle.Fill;
                tableLayout.AutoSize = false;
                tableLayout.AutoScroll = true;
                tableLayout.Name = "tableLayoutPanel1";
                tableLayout.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

                orderListPanel.Controls.Add(tableLayout);

                subTotalLbl.Text = "$" + subTotal;
                shippingHandlingLbl.Text = " $4.00";
                totalLbl.Text = "$" + (subTotal + 4);

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.StackTrace);
            }
        }

        private void newCardRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (newCardRadioBtn.Checked)
            {
                cardTypeCmbBox.Enabled = true;
                cardNumberTxtBox.Enabled = true;
            }
            else
            {
                cardTypeCmbBox.Enabled = false;
                cardNumberTxtBox.Enabled = false;
                
            }
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

            var UserName = ShoppingCartData.getInstance().UserName;
            var customerInfo = bookstoreEntities1.customers.FirstOrDefault(c => c.username == UserName);
            custRegisterForm.usernameTxtBox.ReadOnly = true;
            custRegisterForm.fNameTxtBox.Text = customerInfo.fname;
            custRegisterForm.lNameTxtBox.Text = customerInfo.lname;
            custRegisterForm.addressTxtBox.Text = customerInfo.address;
            custRegisterForm.cityTxtBox.Text = customerInfo.city;
            custRegisterForm.zipTxtBox.Text = customerInfo.zip.ToString();
            custRegisterForm.pinTxtBox.Text = customerInfo.pin;
            custRegisterForm.reTypePinTxtBox.Text = customerInfo.pin;
            custRegisterForm.cardNumberTxtBox.Text = customerInfo.creditcardnumber;
            custRegisterForm.cardExpTxtBox.Text = customerInfo.expirydate;
            custRegisterForm.btnRegister.Text = "Update";
            custRegisterForm.btnDontRegister.Text = "Cancel";
            custRegisterForm.btnRegister.Click += (o, args) => custRegisterForm.Close();
            custRegisterForm.setStateCardTypeInfo(customerInfo.state,customerInfo.creditcardtype);
            custRegisterForm.ShowDialog();
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var username = ShoppingCartData.getInstance().UserName;

                if (newCardRadioBtn.Checked)
                {
                    var creditcardtype = cardTypeCmbBox.SelectedItem.ToString();
                    var creditCardNumber = cardNumberTxtBox.Text;

                    var customer = bookstoreEntities1.customers.FirstOrDefault(c => c.username == username);
                    customer.creditcardnumber = creditCardNumber;
                    customer.creditcardtype = creditcardtype;

                    bookstoreEntities1.customers.AddOrUpdate(customer);
                    
                }
                foreach (var bookResult in ShoppingCartData.getInstance().BookLsListings )
                {
                    book book = bookResult.Book;
                    book.quantity = (bookResult.Book.quantity - bookResult.BookQuantity);
                    bookstoreEntities1.books.AddOrUpdate(book);
                    bookstoreEntities1.SaveChanges();
                }

                
                ProofOfPurchase proofOfPurchase = new ProofOfPurchase();
                proofOfPurchase.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                
                
            }
        }

        private void ConfirmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = ShoppingCart.getInstance();
            shoppingCart.Show();
            this.Hide();
        }

        



           }
    }

