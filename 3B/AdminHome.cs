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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void manageBookCatalogButton_Click(object sender, EventArgs e)
        {
            ManageBookstoreCatalog mbc = new ManageBookstoreCatalog();
            mbc.Show();
            this.Hide();
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            PlacingOrders po = new PlacingOrders();
            po.Show();
            this.Hide();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            ReportMenu rm = new ReportMenu();
            rm.Show();
            this.Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateAdminProfile uap = new UpdateAdminProfile();
            uap.Show();
            this.Hide();
        }

        private void systemMaintButton_Click(object sender, EventArgs e)
        {

        }

       

      
    }
}
