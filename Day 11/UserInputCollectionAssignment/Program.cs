using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputCollectionAssignment
{
    class Program
    {
        int id;
        string name;
        int marks;
        //public static  void inp()
        //{
        //    Console.WriteLine("enter student id");
        //    int id = int.Parse(Console.ReadLine());
        //    Console.WriteLine("enter student name");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("enter student marks");
        //    int marks = int.Parse(Console.ReadLine());
        //}
        public int Id   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public int Marks   // property
        {
            get { return marks; }   // get method
            set { marks = value; }  // set method
        }
        public void inp(Program p1)
        {
            Console.WriteLine("enter Id");
            p1.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Name");
            p1.Name = Console.ReadLine();
            Console.WriteLine("enter Marks");
            p1.Marks = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.inp(p1);
            Hashtable h1 = new Hashtable();
            h1.Add("st_id:", p1.Id);
            h1.Add(" Name:", p1.Name);
            h1.Add("Total_Marks:", p1.Marks);
            foreach(object key in h1.Keys)
            {
                Console.WriteLine(key + " " + h1[key]);
            }
        }
    }
}
