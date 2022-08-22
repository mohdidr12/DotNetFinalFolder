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
        public void InsertFun(int bookid,string bookname,string author,string publisher,double price)
        {
            if(ds.Insert( bookid,bookname,author,publisher,price))
            {
                Console.WriteLine("books Details Added Sucesfully");
            }
            else
            {
                Console.WriteLine("books Details Not  Added Sucesfully");
            }
        }
        public void GetBooksFun()
        { 
            if(ds.GetAllBooks())
            {
                Console.WriteLine("books Are Shown below");
            }
            else
            {
                Console.WriteLine("Unable to shown the books ");
            }
        }
        public void DeleteBookFun(int bid)
        {
            if(ds.DeleteBooks(bid))
            {
                Console.WriteLine("books deleted Successfully");
            }
            else
            {
                Console.WriteLine("books deleted UnSuccessfully");
            }
        }
        public void UpdateFun(int bid,string bookname,double price)
        {
            if (ds.UpdateBook(bid,bookname,price))
            {
                Console.WriteLine("books Updated Successfully");
            }
            else
            {
                Console.WriteLine("books Not Updated Successfully");
            }

        }

    }

}

