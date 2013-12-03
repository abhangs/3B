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
    public partial class Report2 : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=BUNKMASTER-PC;Initial Catalog=bookstore;Integrated Security=True");
        SqlCommand cmd;
        
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                cmd = new SqlCommand("select categoryname as Category, sum(quantity) as Total_Qty_of_Books from books join category on books.categoryid=category.categoryid group by categoryname", sc);

               SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();

              sqlDataAdapter1.SelectCommand = cmd;

               dataGridView1.AutoGenerateColumns = true;
    
              DataTable dt = new DataTable();
               sqlDataAdapter1.Fill(dt);

               bindingSource1.DataSource = dt;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView1.Refresh();
                  
                sc.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error in showing report 2");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Report2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReportMenu rm=new ReportMenu();
            rm.Show();
            this.Hide();

        }
    }
}
