using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3B
{
    class ShoppingCartData
    {
        private static bookstoreEntities1 bookstoreEntities1;
        private string userName;
        private string lastCategorySearched;

        private static customer customer;

        public customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public  string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public class BookListing
        {
            private book book;
            private int bookQuantity;

            public book Book
            {
                get { return book; }
                set { book = value; }
            }

            public int BookQuantity
            {
                get { return bookQuantity; }
                set { bookQuantity = value; }
            }
        }

        private List<BookListing> bookLsListings;


        public List<BookListing> BookLsListings
        {
            get { return bookLsListings; }
            set { bookLsListings = value; }
        }

        public string LastCategorySearched
        {
            get { return lastCategorySearched; }
            set { lastCategorySearched = value; }
        }


        public static ShoppingCartData INSTANCE = new ShoppingCartData();

        private ShoppingCartData()
        {
            UserName = "Temporary User";
            bookLsListings = new List<BookListing>();
            bookstoreEntities1 = new bookstoreEntities1();
            customer = new customer();
            
        }

        public static ShoppingCartData getInstance()
        {
           
            
                if (INSTANCE == null)
                    INSTANCE = new ShoppingCartData();

                return INSTANCE;
            
                
        }

        public  void getCustomerData()
        {
            try
            {
                if (UserName != "Temporary User")
                {
                    var result = bookstoreEntities1.customers.Where(c => c.username.Equals(UserName));
                    if (result.FirstOrDefault() != null)
                    {
                        customer.fname = result.FirstOrDefault().fname;
                        customer.lname = result.FirstOrDefault().lname;
                        customer.address = result.FirstOrDefault().address;
                        customer.state = result.FirstOrDefault().state;
                        customer.zip = result.FirstOrDefault().zip;
                    }
                }
            }
            catch (Exception exception)
            {
                
                MessageBox.Show(exception.StackTrace);
            }
        }



       
    }
}
