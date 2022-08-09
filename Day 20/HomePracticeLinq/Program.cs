using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> myLinqQuery = from obj in list
                              where obj > 2
                              select obj;
            foreach(int i in myLinqQuery)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("********************************************");
            //using where
            var myLinqQuery2 = list.Where(obj => obj > 2);
            foreach (int i in myLinqQuery)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("********************************************");
            var myLinqQuery3 = (from obj in list
                              
                              select obj).Max();
            Console.WriteLine(myLinqQuery3);
            Console.WriteLine("********************************************");
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){id=1,name="idris",Email="idris@gmail.com"},
                new Employee(){id=2,name="umar",Email="umar@gmail.com"},
                  new Employee(){id=3,name="iram",Email="iram@gmail.com"}
            };
            var query5 = (from emp in employees
                          select new Employee()
                          {
                              id = emp.id,
                             Email = emp.Email
                          }).ToList();
            foreach (Employee e in query5)
            {
                Console.WriteLine(e.id + " ," + e.name+" ,"+e.Email);
            }

            var query6 = (from emp in employees
                          select new Student()
                          {
                              StId = emp.id,
                              stEmail = emp.Email
                          }).ToList();
            foreach (var obj in query6)
            {
                Console.WriteLine(obj.StId + " ," + obj.stName + " ," + obj.stEmail);
            }


            // using
            var query7 = employees.Select(obj => obj.id).ToList();

            var selectMethod = employees.Select(emp => new Student()
            {
                StId = emp.id,
                stEmail = emp.Email
            }
                ).ToList();

            //foreach(var emp in query5)
            //{
            //    Console.WriteLine(emp.id + " " + emp.name);
            //}
            IQueryable<Employee> query1 = employees.AsQueryable().Where(x => x.id == 1);
            //foreach (Employee e in query1)
            //{
            //    Console.WriteLine(e.id + " " + e.name);
            //}





        }
        class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public string Email { get; set; }
        }
    }
}
