using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _3B
{
    public partial class PlacingOrders : Form
    {

        private SqlConnection sc =
            new SqlConnection("Data Source=BUNKMASTER-PC;Initial Catalog=bookstore;Integrated Security=True");

        private SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;

        private DataSet ds;

        public PlacingOrders()
        {
            InitializeComponent();
            lblOrderId.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }

        private void PlacingOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PlacingOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        public bool LoadOrders()
        {
            try
            {
                sc.Open();
                cmd = new SqlCommand("Select orderid, bookid, quantity from Orders where deleted!=1 and pending!=0", sc);
                // SqlDataReader sdr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                sc.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                StaticLoginInfo.currRow = 0;
                StaticLoginInfo.maxRows = ds.Tables[0].Rows.Count;
                NavigateCopies();
                txtNumberOfOrders.Text = ds.Tables[0].Rows.Count.ToString();
                txtOrderNumber.Text = "1";
                return true;
            }

            else
            {
                MessageBox.Show("There are no orders to display");

                //StaticLoginInfo.pendingOrders = false;
                //AdminHome ah = new AdminHome();

                //ah.Show();

                //this.Hide();
                return false;
            }
        }


        private void NavigateCopies()
        {
           

            if (StaticLoginInfo.currRow <= ds.Tables[0].Rows.Count)
            {

                DataRow dRow = ds.Tables[0].Rows[StaticLoginInfo.currRow];

                txtOrderNumber.Text = (StaticLoginInfo.currRow + 1).ToString();

                ISBNTextbox.Text = dRow.ItemArray.GetValue(1).ToString();

                orderQtyTextBox.Text = dRow.ItemArray.GetValue(2).ToString();

                lblOrderId.Text = dRow.ItemArray.GetValue(0).ToString();

                string authors = "";
                int i = 0;
                try
                {
                    sc.Open();
                    cmd1 =
                        new SqlCommand(
                            "select title, minquantity, fname, minit, lname, quantity from books join authors on books.bookid=authors.bookid where books.bookid='" +
                            ISBNTextbox.Text + "'", sc);
                    SqlDataReader sdr = cmd1.ExecuteReader();
                   
                    // SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //ds = new DataSet();
                    //da.Fill(ds);
                    while (sdr.Read())
                    {
                        if (i == 0)
                        {
                            i++;
                            titleTextBox.Text = sdr[0].ToString();
                            minQtyTextBox.Text = sdr[1].ToString();
                            qtyTextBox.Text = sdr[5].ToString();

                        }
                     //   authors = authors + " " + sdr["fname"] + " " + sdr["minit"] + " " + sdr["lname"] + "\n";
                        authors = authors + " " + sdr[2] + " " + sdr[3]+ " " + sdr[4] + "\n";
                    }

                    authorsTxt.Text = authors;
                  

                    sc.Close();
                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }


            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (StaticLoginInfo.currRow ==0)
            {
                MessageBox.Show("This is the first order");
                return;
            }
            
            StaticLoginInfo.currRow--;
            NavigateCopies();
        }

        private void nextOrderButton_Click(object sender, EventArgs e)
        {
            if (StaticLoginInfo.currRow ==StaticLoginInfo.maxRows-1)
            {
                MessageBox.Show("This is the last order");
                return;
            }
            StaticLoginInfo.currRow++;
            NavigateCopies();
        }

        private void submitOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                cmd2 = new SqlCommand("Update books set quantity=quantity+" + Convert.ToInt32(orderQtyTextBox.Text) +" where bookid= '"+ ISBNTextbox.Text+ "'", sc);
                cmd2.ExecuteNonQuery();

                cmd2 = new SqlCommand("update orders set pending=0 where orderid= " + Convert.ToInt16(lblOrderId.Text), sc);
                cmd2.ExecuteNonQuery();
                sc.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("error in submitting the order" + ex.ToString());
                Application.Exit();
            }
            MessageBox.Show("Order Submitted");


            //PlacingOrders po = new PlacingOrders();

            //if (StaticLoginInfo.pendingOrders)
            //{

            //    po.Show();
            //    this.Hide();
            //}

            if(!LoadOrders())
                this.Hide();
        }



        private void skipOrderButton_Click(object sender, EventArgs e)
        {

            try
            {
                sc.Open();
                cmd2 = new SqlCommand("Update orders set deleted=1 where orderid=" + Convert.ToInt16(lblOrderId.Text),
                    sc);
                cmd2.ExecuteNonQuery();
                sc.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("error in removing the order" + ex.ToString());
                Application.Exit();
            }
            MessageBox.Show("Order Removed");


         //   PlacingOrders po = new PlacingOrders();
            if (!LoadOrders())
                this.Hide();

        }
    }
}