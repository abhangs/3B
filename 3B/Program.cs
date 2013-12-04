using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3B
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());

            Application.ApplicationExit += ApplicationExit_SaveData();
        }

        private static EventHandler ApplicationExit_SaveData()
        {
            if (ShoppingCartData.getInstance().UserName != "Temporary User")
            {
                var bookstoreEntities1 = new bookstoreEntities1();
                var username = ShoppingCartData.getInstance().UserName;
                var category = ShoppingCartData.getInstance().LastCategorySearched;
                var categorysearched =
                    bookstoreEntities1.categories.Where(c => c.categoryname == category).Select(c => c.categoryid);
                
                bookstoreEntities1.customers.Where(c => c.username == username).ToList().ForEach( c => c.categorylastsearched = categorysearched.FirstOrDefault());
                bookstoreEntities1.SaveChanges();
            }

          //  Application.Exit();
            return null;
        }
    }
}
