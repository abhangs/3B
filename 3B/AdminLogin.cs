using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3B
{


    public partial class AdminLogin : Form
    {
        private bookstoreEntities1 bookstoreEntities1;

        public AdminLogin()
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
                if ((bookstoreEntities1.admins.Where(a => a.username == username && a.pin == pin)).Any())
                {
                    StaticLoginInfo.adminName = username;
                    AdminHome ah=new AdminHome();
                    ah.Show();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mainForm mnForm = new mainForm();
            mnForm.Show();
            this.Hide();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
