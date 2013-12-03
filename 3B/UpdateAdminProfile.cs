using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _3B
{
    public partial class UpdateAdminProfile : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=BUNKMASTER-PC;Initial Catalog=bookstore;Integrated Security=True"); 
        SqlCommand cmd;


        public UpdateAdminProfile()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string username =usernameTxtBox.Text;
            string pin= pinTxtBox.Text;
            string repin= reTypePinTxtBox.Text;
            if (pin!=repin)
            {
               MessageBox.Show("Pins do not match");
                              
            }

            string fname = fNameTxtBox.Text;
            string lname = lNameTxtBox.Text;
            string address = addressTxtBox.Text;
            string city = cityTxtBox.Text;
                        
            string state = stateCmbBox.SelectedItem.ToString();
            string zip = zipTxtBox.Text;
            string phone = phoneNumberTextBox.Text;

            try
            {
             sc.Open();
             cmd = new SqlCommand("Update admin set pin='"+pin+"', fname='"+fname+"', lname='"+lname+"', address='"+address+"', city='"+city+"', state='"+state+"',zip='"+zip+"' where username='"+username+"'", sc);
             cmd.ExecuteNonQuery();

             cmd = new SqlCommand("Update adminphone set phonenumber= '"+phone+"' where admin='"+username+"'", sc);
             cmd.ExecuteNonQuery();
                sc.Close();
                

            }
            catch(SqlException ex)
            {
                MessageBox.Show("error in updating admin profile "+ ex.ToString());
                Application.Exit();
            }
            MessageBox.Show("Update Successful");
        }

        private void UpdateAdminProfile_Load(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                cmd = new SqlCommand("Select statename from states", sc);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //  dt.Columns.Add("stateabbr", typeof(string));
                dt.Columns.Add("statename", typeof(string));
                dt.Load(dr);

                stateCmbBox.ValueMember = "statename";
                stateCmbBox.DisplayMember = "statename";
                stateCmbBox.DataSource = dt;


                sc.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }

            string username = StaticLoginInfo.adminName;


            try
            {
                sc.Open();
                cmd = new SqlCommand("Select * from admin join adminphone on username=admin where username='"+username+"'", sc);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    usernameTxtBox.Text = sdr["username"].ToString();                   
                    pinTxtBox.Text = sdr["pin"].ToString();
                    reTypePinTxtBox.Text = sdr["pin"].ToString();
                    fNameTxtBox.Text = sdr["fname"].ToString();
                    lNameTxtBox.Text = sdr["lname"].ToString();
                    hireDateTxtBox.Text = sdr["hiredate"].ToString();
                    cityTxtBox.Text = sdr["city"].ToString();
                    addressTxtBox.Text = sdr["address"].ToString();                   
                    zipTxtBox.Text = sdr["zip"].ToString();
                    phoneNumberTextBox.Text = sdr["phonenumber"].ToString();
                    stateCmbBox.SelectedItem = stateCmbBox.FindString(sdr["state"].ToString());

                }
                sc.Close();
            }
                 catch (SqlException ex)
            {
                MessageBox.Show("Error in loading form ");
            }

            
            
        }

        private void UpdateAdminProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
