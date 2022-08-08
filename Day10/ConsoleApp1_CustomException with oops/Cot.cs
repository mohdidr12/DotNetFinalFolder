using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_CustomException_with_oops
{
    class Cot:Furniture
    {
        public string _COttype;
        public string _Memebercap;
        public int _rate;

        public void getdata2()
        {
            Console.WriteLine("Enter the type of Cot want WOOD, STEEL");
            this._COttype = Console.ReadLine();
            Console.WriteLine("Enter the member capacity SINGLE, DOUBLE");
            this._Memebercap = Console.ReadLine();
            

        }
        public void showdetails2()
        {
            Console.WriteLine("purpose=" + _COttype);
            Console.WriteLine("Cot type=" + _Memebercap);
            Console.WriteLine("Enter the quantity");
            this._Qty = int.Parse(Console.ReadLine());
            if (_COttype == "WOOD" && _Memebercap == "SINGLE")
            {
                _rate = 2000;
            }
            if (_COttype == "WOOD" && _Memebercap == "DOUBLE")
            {
                _rate = 3500;
            }
            if (_COttype == "STEEL" && _Memebercap == "SINGLE")
            {
                _rate = 3000;
            }
            if (_COttype == "STEEL" && _Memebercap == "DOUBLE")
            {
                _rate = 5500;
            }
            _TotalAmt = _Qty * _rate;
            Console.WriteLine("Total amount=" + _TotalAmt);
        }

    }
}
