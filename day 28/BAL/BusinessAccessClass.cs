using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class BusinessAccessClass
    {
        DataAccessClass ds = new DataAccessClass();
        public bool InsertFun(int bookid,string bookname,string author,string publisher,double price)
        {
            if(ds.Insert( bookid,bookname,author,publisher,price))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object GetBooksFun()
        {
            //if(ds.GetAllBooks())
            //{
            //    return 
            //}
            //else
            //{
            //    return false;
            //}
          var sel =   ds.GetAllBooks();
            return sel;
        }
        public bool DeleteBookFun(int bid)
        {
            if(ds.DeleteBooks(bid))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateFun(int bid,string bname)
        {
            if (ds.UpdateBook(bid,bname))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}

