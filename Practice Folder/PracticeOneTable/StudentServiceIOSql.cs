using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOneTable
{
    class StudentServiceIOSql
    {
        SqlConnectionClass sc = new SqlConnectionClass();
        public void InsertValuesUser()
        {
            Console.WriteLine("Enter id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            byte age = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter standard");
            byte standard = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            sc.AddData(id, name, age, standard, city);
        }
        public void DisplayData()
        {
            sc.DisplayAll();
            
        }
        public void Update()
        {
            Console.WriteLine("select which want you to Update");
            Console.WriteLine("1.UpdateAge\n 2.UpdateCity\n");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("enter Id of Student");
                    string str = Console.ReadLine();
                    Console.WriteLine("enter Updated Age of Student");
                    byte upAge = byte.Parse(Console.ReadLine());
                    sc.UpdateAge(str, upAge);
                    break;
                case 2:
                    Console.WriteLine("enter Id of Student");
                    string str1 = Console.ReadLine();
                    Console.WriteLine("enter Updated City of Student");
                    string upcity = Console.ReadLine();
                    sc.UpdateCity(str1,upcity);
                    break;
                default:
                    Console.WriteLine("please enter the valid Option");
                    break;
            }
        }
        public void DeleteStudent()
        {
            Console.WriteLine("enter id of student which you want to delete");
            string id = Console.ReadLine();
            sc.Delete(id);
        }
    }
}
