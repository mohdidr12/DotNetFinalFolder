using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOneTable
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Boolean flag = true;
            StudentServiceIOSql inp = new StudentServiceIOSql();
            while (flag)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1.Insert Student");
                Console.WriteLine("2.Update Student");
                Console.WriteLine("3.Delete Student");
                Console.WriteLine("4.Display Students");
                Console.WriteLine("*****************************************");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        inp.InsertValuesUser();
                        break;
                    case 2:
                        inp.Update();
                        break;
                    case 3:
                        inp.DeleteStudent();
                        break;
                    case 4:
                        inp.DisplayData();
                        break;
                    default:
                        Console.WriteLine("No Valid Option from the Above Selection ");
                        flag = false;
                        break;

                }
            }
        }
    }
}
