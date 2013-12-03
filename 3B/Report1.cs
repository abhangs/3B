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
    public partial class Report1 : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=BUNKMASTER-PC;Initial Catalog=bookstore;Integrated Security=True");
        SqlCommand cmd;

        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            monthTxtBox.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString().Substring(2,2); ;
            try
            {
                sc.Open();
                cmd = new SqlCommand("select categoryname as Category, sum(saleslines.price) as Total_Sales from category join books  on category.categoryid=books.categoryid join saleslines on saleslines.bookid=books.bookid join sales on sales.salesid= saleslines.salesid where [date] in (select sales.date from sales where CONVERT(VARCHAR(2), sales.date,1) in((SELECT CONVERT(VARCHAR(2), GETDATE(), 1) AS [MM/DD/YY] )-1)) group by category.categoryname", sc);

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
                MessageBox.Show("Error in generating report");
                Application.Exit();
            }
          
        }

        private void Report1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReportMenu rm = new ReportMenu();
            rm.Show();
            this.Hide();


        }
    }
}
