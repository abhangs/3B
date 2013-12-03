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

namespace _3B
{
    public partial class custRegisterForm : Form
    {
        private bookstoreEntities1 bookstoreEntities1;
        public custRegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            if (btnRegister.Text == "Register")
            {
                var userName = usernameTxtBox.Text;
                var result = bookstoreEntities1.customers.FirstOrDefault(c => c.username == userName);
                if (result != null)
                {
                    MessageBox.Show("Username already taken! Please choose another Username", "Error!", MessageBoxButtons.OK);
                    return;
                }
                if (pinTxtBox.Text != reTypePinTxtBox.Text)
                {
                    MessageBox.Show("PIN's entered do not match!", "Error!", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    var pin = pinTxtBox.Text;
                    var fname = fNameTxtBox.Text;
                    var lname = lNameTxtBox.Text;
                    var address = addressTxtBox.Text;
                    var city = cityTxtBox.Text;
                    var state = stateCmbBox.SelectedItem.ToString();
                    var zip = int.Parse(zipTxtBox.Text);
                    var cardType = cardTypeCmbBox.SelectedItem.ToString();
                    var cardNumber = cardNumberTxtBox.Text;
                    var cardExpiry = cardExpTxtBox.Text;

                    var customer = new customer
                    {
                        username = userName,
                        address = address,
                        pin = pin,
                        fname = fname,
                        lname = lname,
                        city = city,
                        state = state,
                        zip = zip,
                        creditcardtype = cardType,
                        creditcardnumber = cardNumber,
                        expirydate = cardExpiry
                    };

                    bookstoreEntities1.customers.Add(customer);
                    if (bookstoreEntities1.SaveChanges() > 1)
                        MessageBox.Show("Customer successfully registerd", "Info", MessageBoxButtons.OK);
                    ShoppingCartData.getInstance().UserName = userName;

                    SearchForm searchForm = SearchForm.getInstance();
                    searchForm.Show();
                    this.Close();

                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.StackTrace);
                }

                
            }


            else
            {
                var userName = usernameTxtBox.Text;
                
                //var result = bookstoreEntities1.customers.FirstOrDefault(c => c.username == userName);
                //if (result != null)
                //{
                //    MessageBox.Show("Username already taken! Please choose another Username", "Error!", MessageBoxButtons.OK);
                //    return;
                //}
                if (pinTxtBox.Text != reTypePinTxtBox.Text)
                {
                    MessageBox.Show("PIN's entered do not match!", "Error!", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    var pin = pinTxtBox.Text;
                    var fname = fNameTxtBox.Text;
                    var lname = lNameTxtBox.Text;
                    var address = addressTxtBox.Text;
                    var city = cityTxtBox.Text;
                    var state = stateCmbBox.SelectedItem.ToString();
                    var zip = int.Parse(zipTxtBox.Text);
                    var cardType = cardTypeCmbBox.SelectedItem.ToString();
                    var cardNumber = cardNumberTxtBox.Text;
                    var cardExpiry = cardExpTxtBox.Text;

                    var customer = new customer
                    {
                        username = userName,
                        address = address,
                        pin = pin,
                        fname = fname,
                        lname = lname,
                        city = city,
                        state = state,
                        zip = zip,
                        creditcardtype = cardType,
                        creditcardnumber = cardNumber,
                        expirydate = cardExpiry
                    };

                    bookstoreEntities1.customers.AddOrUpdate( c => c.username == userName);
                    if (bookstoreEntities1.SaveChanges() > 1)
                    {
                        MessageBox.Show("Customer details updated successfully", "Info", MessageBoxButtons.OK);
                    }
                    ShoppingCartData.getInstance().UserName = userName;

                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.StackTrace);
                }

            }


            
        }

        private void custRegisterForm_Load(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();
            var states = from s in bookstoreEntities1.states select s;
            foreach (var state in states)
            {
                stateCmbBox.Items.Add(state.statename); 
            }

            var cardType = bookstoreEntities1.creditcardtypes;
            foreach (var creditcardtype in cardType)
            {
                cardTypeCmbBox.Items.Add(creditcardtype.creditcardtype1);
            }

        }

        private void btnDontRegister_Click(object sender, EventArgs e)
        {
            if (btnDontRegister.Text == "Cancel")
            {
                mainForm mnForm = new mainForm();
                mnForm.Show();
                this.Hide();

            }
            else
            {
                if (ShoppingCartData.getInstance().UserName == "Temporary User")
                    MessageBox.Show("In order to proceed with the payment, you need to register first.", "Message",
                        MessageBoxButtons.OK);
                else
                {
                    this.Close();
                }
            }

        }

        private void custRegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
