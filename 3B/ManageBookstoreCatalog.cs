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
    public partial class ManageBookstoreCatalog : Form
    {
        public ManageBookstoreCatalog()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertNewBook insertNewBook = new InsertNewBook();
            insertNewBook.Show();
            this.Hide();
        }

        private void modifyDeleteButton_Click(object sender, EventArgs e)
        {
            AdminSearchForm adminSearchForm = new AdminSearchForm();
            adminSearchForm.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}
