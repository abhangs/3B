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
    public partial class Report5 : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=BUNKMASTER-PC;Initial Catalog=bookstore;Integrated Security=True");
        SqlCommand cmd;

        public Report5()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReportMenu rm = new ReportMenu();
            rm.Show();
            this.Hide();
        }

        private void Report5_Load(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                cmd = new SqlCommand("select * from categoryBuyers", sc);

                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();

                sqlDataAdapter1.SelectCommand = cmd;

                dataGridView1.AutoGenerateColumns = true;

                DataTable dt = new DataTable();
                sqlDataAdapter1.Fill(dt);

              //  bindingSource1.DataSource = dt;
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
    }
}
