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
    public partial class ModifyDeleteBooks : Form
    {
        public ModifyDeleteBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome ah=new AdminHome();
            ah.Show();
            this.Hide();
        }

        private void ModifyDeleteBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
