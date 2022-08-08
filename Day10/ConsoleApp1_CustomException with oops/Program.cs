using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_CustomException_with_oops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            char u;
            int balance = 7000;

            do
            {
                Console.WriteLine("1. Chair");
                Console.WriteLine("2. Cot");
                Console.WriteLine("3. Exit");
                a = int.Parse(Console.ReadLine());


                switch (a)
                {
                    case 1:
                        {
                            Furniture f = new Furniture();
                            f.getdata();
                            Console.WriteLine("\n");
                            f.showdetails();
                            Console.WriteLine("\n");
                            Chair r = new Chair();
                            r.getdata1();
                            Console.WriteLine("\n");
                            r.showdetails1();

                            try
                            {
                                if (r._TotalAmt > balance)
                                {
                                    throw new Exception("Insufficient Balance....");
                                }
                                else
                                {
                                    balance = balance - r._TotalAmt;
                                    Console.WriteLine("Remaining Amount=" + balance);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case 2:
                        {
                            Furniture f = new Furniture();
                            f.getdata();
                            Console.WriteLine("\n");
                            f.showdetails();
                            Console.WriteLine("\n");
                            Cot s = new Cot();
                            s.getdata2();
                            Console.WriteLine("\n");
                            s.showdetails2();


                            try
                            {
                                if (s._TotalAmt > balance)
                                {
                                    throw new Exception("Insufficient Balance....");
                                }
                                else
                                {
                                    balance = balance - s._TotalAmt;
                                    Console.WriteLine("Remaining Amount=" + balance);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the correct choice");

                            break;
                        }

                }
                Console.WriteLine("IF you want to enter again please press 'y' or'Y'");
                u = char.Parse(Console.ReadLine());

            } while (u == 'y' || u == 'Y');
            
            Console.ReadLine();
        }
    }
}
