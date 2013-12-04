using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace _3B
{
    public partial class SystemMaintenance : Form
    {
        private bookstoreEntities1 bookstoreEntities1;
        private TableLayoutPanel catTableLayoutPanel;
        private TableLayoutPanel stateTableLayoutPanel;
        private TableLayoutPanel cardTableLayoutPanel;

        public SystemMaintenance()
        {
            InitializeComponent();
        }

       private void SystemMaintenance_Load(object sender, EventArgs e)
        {
            bookstoreEntities1 = new bookstoreEntities1();

            //Load Category
            catTableLayoutPanel = new TableLayoutPanel();
            var categories = bookstoreEntities1.categories.Select(c => c.categoryname);
            foreach (var category in categories)
            {
                var textBox = new TextBox { Text = category };
                catTableLayoutPanel.Controls.Add(textBox);
            }

           fewerCatBtn.Enabled = categories.Count() > 1;

            catTableLayoutPanel.Location = new Point(139, 37);
            catTableLayoutPanel.Size = new Size(370, 144);
            catTableLayoutPanel.Dock = DockStyle.Fill;
            catTableLayoutPanel.AutoSize = false;
            catTableLayoutPanel.AutoScroll = true;
            catTableLayoutPanel.Name = "catTableLayoutPanel";
            catTableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            categoryPanel.Controls.Add(catTableLayoutPanel);




            //Load States
            stateTableLayoutPanel = new TableLayoutPanel();
            var states = bookstoreEntities1.states;
            foreach (var state in states)
            {
                var insertStateControl = new InsertBookControl_Author();
                insertStateControl.authorFnameTxt.Text = state.stateabbr;
                insertStateControl.authorLnameTxt.Text = state.statename;
                stateTableLayoutPanel.Controls.Add(insertStateControl);
            }
           
            fewerStatBtn.Enabled = states.Count()>1;

            stateTableLayoutPanel.Location = new Point(139, 196);
            stateTableLayoutPanel.Size = new Size(370, 144);
            stateTableLayoutPanel.Dock = DockStyle.Fill;
            stateTableLayoutPanel.AutoSize = false;
            stateTableLayoutPanel.AutoScroll = true;
            stateTableLayoutPanel.Name = "stateTableLayoutPanel";
            stateTableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
           statePanel.Controls.Add(stateTableLayoutPanel);



            //Load credit card type
            cardTableLayoutPanel = new TableLayoutPanel();
           var creditcardtypes = bookstoreEntities1.creditcardtypes;
            foreach (var creditcardtype in creditcardtypes)
            {
                var textBox = new TextBox { Text = creditcardtype.creditcardtype1 };
                cardTableLayoutPanel.Controls.Add(textBox);
            }
            fewerCardBtn.Enabled = creditcardtypes.Count()>1;
            cardTableLayoutPanel.Location = new Point(139, 356);
            cardTableLayoutPanel.Size = new Size(370, 144);
            cardTableLayoutPanel.Dock = DockStyle.Fill;
            cardTableLayoutPanel.AutoSize = false;
            cardTableLayoutPanel.AutoScroll = true;
            cardTableLayoutPanel.Name = "cardTableLayoutPanel";
            cardTableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
           creditCardPanel.Controls.Add(cardTableLayoutPanel);



        }

       private void moreCatBtn_Click(object sender, EventArgs e)
       {
           TextBox textBox = new TextBox();
           catTableLayoutPanel.Controls.Add(textBox);
           fewerCatBtn.Enabled = true;

       }

       private void moreStatBtn_Click(object sender, EventArgs e)
       {
           InsertBookControl_Author insertStateControl = new InsertBookControl_Author();
           stateTableLayoutPanel.Controls.Add(insertStateControl);
           fewerStatBtn.Enabled = true;
       }

       private void moreCardBtn_Click(object sender, EventArgs e)
       {
           TextBox textBox = new TextBox();
           cardTableLayoutPanel.Controls.Add(textBox);
           fewerCardBtn.Enabled = true;
       }

       private void fewerCatBtn_Click(object sender, EventArgs e)
       {
           try
           {
               bookstoreEntities1 = new bookstoreEntities1();
               var categoryName = (TextBox)catTableLayoutPanel.GetControlFromPosition(0, catTableLayoutPanel.Controls.Count - 1);
               var categoryId = bookstoreEntities1.categories.Where(c => c.categoryname == categoryName.Text).Select(c => c.categoryid).FirstOrDefault();
               var result = bookstoreEntities1.books.Where(b => b.categoryid == categoryId);

               if (result.Count() > 1)
               {
                   MessageBox.Show("Cannot remove category because books are associated");
                   return;

               }

               catTableLayoutPanel.Controls.RemoveAt(catTableLayoutPanel.Controls.Count - 1);
               if (catTableLayoutPanel.Controls.Count == 1)
                   fewerCatBtn.Enabled = false;
           }
           catch (Exception exception)
           {
               
               
           }
       }

       private void fewerStatBtn_Click(object sender, EventArgs e)
       {
           try
           {
               bookstoreEntities1 = new bookstoreEntities1();
               var insertBookControlAuthor =
                   (InsertBookControl_Author)
                       stateTableLayoutPanel.GetControlFromPosition(0, stateTableLayoutPanel.Controls.Count - 1);
               var stateabbr = insertBookControlAuthor.authorFnameTxt.Text;
               var statename = insertBookControlAuthor.authorLnameTxt.Text;


               var result = bookstoreEntities1.customers.Where(c => c.state == statename);
               if (result.Count() > 1)
               {
                   MessageBox.Show("Cannot remove state because customer is associated");
                   return;
               }
               stateTableLayoutPanel.Controls.RemoveAt(stateTableLayoutPanel.Controls.Count - 1);
               if (stateTableLayoutPanel.Controls.Count == 1)
                   fewerStatBtn.Enabled = false;
           }
           catch (Exception exception)
           {
               
              
           }
       }

       private void fewerCardBtn_Click(object sender, EventArgs e)
       {
           try
           {
               bookstoreEntities1 = new bookstoreEntities1();
               var cardName = (TextBox)cardTableLayoutPanel.GetControlFromPosition(0, catTableLayoutPanel.Controls.Count - 1);
               var cardType = cardName.Text;
               var result = bookstoreEntities1.customers.Where(c => c.creditcardtype.Contains(cardType));
               if (result.Count() > 1)
               {
                   MessageBox.Show("Cannot remove card type because associated with customer information");
                   return;

               }

               cardTableLayoutPanel.Controls.RemoveAt(catTableLayoutPanel.Controls.Count - 1);
               if (cardTableLayoutPanel.Controls.Count == 1)
                   fewerCatBtn.Enabled = false;
           }
           catch (Exception exception)
           {
               
               
           }
       }
    }
}
