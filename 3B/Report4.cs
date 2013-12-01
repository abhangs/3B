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
    public partial class Report4 : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=SONY-VAIO\\SQLSERVER2012;Initial Catalog=bookstore;Integrated Security=True");
        SqlCommand cmd;


        public Report4()
        {
            InitializeComponent();
        }

        private void Report4_Load(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                cmd = new SqlCommand("select sum(s.price*s.quantity) as Total_Sales, categoryname as Categoty from category c join books b on b.categoryid=c.categoryid  join saleslines s on s.bookid=b.bookid where s.price in (select max(price) as expensivebook from books where b.bookid=books.bookid  group by categoryid order by expensivebook desc)  group by categoryname", sc);
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

            }

                
             
              

        }

        private void Report4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
