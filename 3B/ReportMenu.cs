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
    public partial class ReportMenu : Form
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (first.Checked)
            {
                Report1 rp = new Report1();
                rp.Show();
                this.Hide();
            }
            else if (second.Checked)
            {
                Report2 rp = new Report2();
                rp.Show();
                this.Hide();
            }
            else if (third.Checked)
            {
                Report3 rp= new Report3();
                rp.Show();
                this.Hide();

            }
            else if (fourth.Checked)
            {
                Report4 rp = new Report4();
                rp.Show();
                this.Hide();
            }
            else if (fifth.Checked)
            {
                Report5 rp = new Report5();
                rp.Show();
                this.Hide();

            }
            else if(radioButton1.Checked)
            {
                StatisticalReport sp = new StatisticalReport();
                sp.Show();
                this.Hide();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }

        private void ReportMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
