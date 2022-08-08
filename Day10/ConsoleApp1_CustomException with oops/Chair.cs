using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_CustomException_with_oops
{
    class Chair:Furniture
    {
        public string _purpose;
        public string _Chairtype;
        public int _Rate;
        
        public void getdata1()
        {
            Console.WriteLine(" select the purpose HOME/OFFICE ");
            this._purpose = Console.ReadLine();
            Console.WriteLine("Select the Chair type- WOOD, STEEL, PLASTIC");
            this._Chairtype = Console.ReadLine();

        }
        public void showdetails1()
        {
            
            Console.WriteLine("purpose=" + _purpose);
            Console.WriteLine("Chair type=" + _Chairtype);
            Console.WriteLine("Enter the quantity you want");
            this._Qty = int.Parse(Console.ReadLine());
            if (_purpose=="HOME"&& _Chairtype=="WOOD")
            {
                this._Rate = 1000;
            }
            if (_purpose == "HOME" && _Chairtype == "STEEL")
            {
                this._Rate = 1100;
            }
            if (_purpose == "HOME" && _Chairtype == "PLASTIC")
            {
                this._Rate = 800;
            }
            if (_purpose == "OFFICE" && _Chairtype == "WOOD")
            {
                this._Rate = 1100;
            }
            if (_purpose == "OFFICE" && _Chairtype == "STEEL")
            {
                this._Rate = 1200;
            }
            if (_purpose == "OFFICE" && _Chairtype == "PLASTIC")
            {
                this._Rate = 1000;
            }
           
            _TotalAmt = _Qty * _Rate;
            Console.WriteLine("Total Amount=" + _TotalAmt);

        }
    }
}
