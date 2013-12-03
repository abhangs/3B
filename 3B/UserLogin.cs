﻿using System;
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
                    SearchForm searchForm = SearchForm.getInstance();
                    searchForm.Show();
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
