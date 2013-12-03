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
    public partial class BookReview : Form
    {
        public BookReview()
        {
            InitializeComponent();
        }

        public static BookReview INSTANCE;

        public static BookReview getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new BookReview();
            }
            return INSTANCE;
        }

        private void BookReview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
