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
                custRegisterForm.Visible = true;
                this.Hide();
            }

            else if (returnCustRadioBox.Checked)
            {
                UserLogin userLogin = new UserLogin();
                userLogin.ShowDialog();
                this.Hide();
            }


        }

        
    }
}
