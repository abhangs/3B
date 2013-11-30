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
            InsertNewBook inb = new InsertNewBook();
            inb.Show();
            this.Hide();
        }

        private void modifyDeleteButton_Click(object sender, EventArgs e)
        {
            ModifyDeleteBooks mdb = new ModifyDeleteBooks();
            mdb.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }
    }
}
