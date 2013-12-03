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
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            GetTotalItems();
        }

        public static SearchResult INSTANCE;

        public static SearchResult getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new SearchResult();
            }

            return INSTANCE;
        }

        public void GetTotalItems()
        {
            this.currentItemCountLbl.Text = "Your Shopping Cart has " + ShoppingCartData.getInstance().BookLsListings.Count + " items";
        }

        private void newSearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm =
                SearchForm.getInstance();
            searchForm.Show();
            this.Hide();
        }

        private void manageCartBtn_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = ShoppingCart.getInstance();
            shoppingCart.OnLoad();
            shoppingCart.Show();
            this.Hide();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {

            if (ShoppingCartData.getInstance().BookLsListings.Count > 0)
            {
                if (ShoppingCartData.getInstance().UserName == "Temporary User")
                {
                    custRegisterForm registerForm = new custRegisterForm();
                    registerForm.ShowDialog();
                }
                else
                {
                    ConfirmOrder confirmOrder = ConfirmOrder.getInstance();
                    confirmOrder.Show();
                    this.Hide();
                }

            }

            else
            {

                MessageBox.Show("No items to checkout", "Error", MessageBoxButtons.OK);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
