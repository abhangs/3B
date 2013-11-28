using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B
{
    class ShoppingCartData
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private List<book> bookList;

        public List<book> BookList
        {
            get { return bookList; }
            set { bookList = value; }
        }

        public static ShoppingCartData INSTANCE = new ShoppingCartData();

        private ShoppingCartData()
        {
            UserName = "Temporary User";
        }

        public static ShoppingCartData getInstance
        {
            get
            {
                if (INSTANCE == null)
                    INSTANCE = new ShoppingCartData();

                return INSTANCE;
            }
                
        }

    }
}
