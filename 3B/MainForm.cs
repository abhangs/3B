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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            
            if (searchRadioButton.Checked)
            {
                SearchForm searchForm = SearchForm.getInstance();
                searchForm.Visible = true;
                this.Hide();
            }

            else if (newCustRadioButton.Checked)
            {
                custRegisterForm custRegisterForm = new custRegisterForm();
                custRegisterForm.btnDontRegister.Text = "Cancel";
                custRegisterForm.Visible = true;

                this.Hide();
            }

            else if (returnCustRadioBox.Checked)
            {
                UserLogin userLogin = new UserLogin();
                userLogin.Show();
                this.Hide();
            }

            else if (adminRadioButton.Checked)
            {
                AdminLogin al= new AdminLogin();
                al.Show();
                this.Hide();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ShoppingCartData.getInstance();
            
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
