using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_CustomException_with_oops
{
    class Furniture
    {
        public string _orderID;
        public string _orderDate;
        public string _furnitureType;
        public int _Qty;
        public int _TotalAmt;
        public string _paymentMode;

        public Furniture(string orderID, string orderDate, string furnitureType,  string paymentmode)
        {
            this._orderID = orderID;
            this._orderDate = orderDate;
            this._furnitureType = furnitureType;
            this._paymentMode = paymentmode;
        }
        public void getdata()
        {

            Console.WriteLine("Enter the order ID");
            this._orderID = Console.ReadLine();
            Console.WriteLine("Enter the Order DATe");
            this._orderDate = Console.ReadLine();
            Console.WriteLine("type of furniture You want  ");
            this._furnitureType = Console.ReadLine();
           // Console.WriteLine("Enter the qty you want");
           // this._Qty = int.Parse(Console.ReadLine());
          //  Console.WriteLine("Total Amount= ");
          //  this._TotalAmt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the payment mode");
            this._paymentMode = Console.ReadLine();
        
        }
        public void showdetails()
        {
            Console.WriteLine("order ID is "+ _orderID);
            
            Console.WriteLine("Enter the Order DATe  "+_orderDate);
            
            Console.WriteLine("type of furniture You want -"+_furnitureType);
          //  this = Console.ReadLine();
           // Console.WriteLine("Enter the qty you want-"+ _Qty);
          //  this.= int.Parse(Console.ReadLine());
          //  Console.WriteLine("Total Amount= "+ _TotalAmt);
          //  this. = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the payment mode-"+_paymentMode);
          //  this = Console.ReadLine();

        }
    }
}
