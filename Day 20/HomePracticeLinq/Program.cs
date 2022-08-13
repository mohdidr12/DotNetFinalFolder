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
            /*
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
                new Employee(){id=1,name="idris",Email="idris@gmail.com",Programming= new List<Techs>
                { 
                } },
                new Employee(){id=2,name="umar",Email="umar@gmail.com",Programming= new List<string>(){"C","C++","JAVA","PHYTHON" }},
                  new Employee(){id=3,name="iram",Email="iram@gmail.com",Programming= new List<string>(){"PHYTHON","JAVA","JS","MY SQL" }}
            };
            var methodSyntax7 = employees.SelectMany(emp => emp.Programming).ToList();
            var QuerySyntax8 = (from emp in employees
                               from skill in emp.Programming
                               select skill).ToList();

            foreach(var emp in QuerySyntax8)
            {
                Console.WriteLine("Pr"+emp);
            }

            var query5 = (from emp in employees
                          select new Employee()
                          {
                              id = emp.id,
                             Email = emp.Email
                          }).ToList();

            var queryMethod3 = employees.Select(emp => new Student()
                {
                  stEmail = emp.Email,
                  stName = emp.name,
                  StId = emp.id
                  }
            );
            foreach(var  e in queryMethod3)
            {
                Console.WriteLine(e.stEmail + " ," + e.stName+" ,"+e.StId);
            }

            var query6 = (from emp in employees
                          select new 
                          {
                              CustomId = emp.id,
                              CustomEmail = emp.Email,
                              CustomName = emp.name
                          }).ToList();
            foreach (var obj in query6)
            {
                Console.WriteLine(obj.CustomId + " ," + obj.CustomName + " ," + obj.CustomEmail);
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
            List<string> strList = new List<string>() { "Nitish", "Kaushik" };
            var queryResult1 = strList.SelectMany(x => x).ToList();
            var queryResult = (from rec in strList
                               from ch in rec
                               select ch).ToList();
            

            Console.ReadLine();

             */

            // OfType Demo

            //var dataSource = new  List<object>(){ "Ada","John","haris",1,2,3,4,5};
            //var methodSyntax = dataSource.OfType<string>().Where(x => x.Length>3).ToList();
            //var querySyntax = (from e in dataSource
            //                   where e is int 
            //                   select e).ToList();

            //    int[] arr = new int[]{ 1, 45, 32, 78, 90, 345, 678 };

            //Reverse Demo

            //     List<int> lList = new List<int>() { 1, 43, 23, 56, 78, 3334, 8999 };
            //     foreach (int i in lList)
            //     {
            //         Console.WriteLine(i);
            //     }
            //     Console.WriteLine("=============================================");
            ////   var em =   lList.AsEnumerable().Reverse();
            //     foreach(int i in lList)
            //     {
            //         Console.WriteLine(i);
            //     }
            Console.ReadLine();


            //All Any and Contains

            //var dataSource = new List<Employee>()
            //{
            //    new Employee{id=1,Marks=40},
            //    new Employee{id=1,Marks=100},
            //    new Employee{id=1,Marks=85},
            //    new Employee{id=1,Marks=20},
            //    new Employee{id=1,Marks=35}
            //};
            //var ms = dataSource.Any(emp => emp.Marks > 85);

            //var qs = (from emp in dataSource
            //          select emp).Any(emp => emp.Marks > 100);
            //List<string> lList = new List<string> { "babu", "mono", "jaanu", "kaalu" };
            //var ms = lList.AsEnumerable().Contains("kaalu");
            //var qs = (from str in lList
            //          select str).Contains("nanu");
            //    List<int> llist = new List<int> { 1, 2, 1, 2, 3, 2, 1, 2, 3, 4, 5, 6 };

            // Except 

            //var datasource = new List<Employee>()
            //{
            //    new Employee{id=1,Firstname="idris"},
            //    new Employee{id=2,Firstname="juned"},
            //    new Employee{id=3,Firstname="kallu"},
            //};
            //var datasource1 = new List<Employee>()
            //{
            //    new Employee{id=1,Firstname="idris"},
            //    new Employee{id=2,Firstname="juned"},
            //    new Employee{id=4,Firstname="manu"},
            //};

            //List<string> lList = new List<string> { "A", "B", "C", "D" };
            //List<string> lList1 = new List<string> { "A", "B", "E", "F" };

            //   var result = lList.Union(lList1).ToList();
            ////  var ms = datasource.Select(x => x.Firstname).Intersect(datasource1.Select(x => x.Firstname)).ToList();
            //   foreach(var i in result)
            //   {
            //       Console.WriteLine(i);
            //   }


            //  Console.WriteLine(ms);
            //Console.WriteLine(qs);
            var dataSource = new List<Employee>()
            {
            new Employee(){id=1,name="idris",address="jaipur"},
            new Employee() { id = 2, name = "Juned", address = "Ajmer" },
            new Employee() { id = 3, name = "Jaanvi", address = "Kota" },
            new Employee() { id = 4, name = "Aamir", address = "Jabalpur" }
            };
            var dataSource1 = new List<Department>()
            {
                 new Department(){id=1,departmentName="IT"},
                 new Department(){id=2,departmentName="Finance"},
                 new Department(){id=3,departmentName="IT"},
                 new Department() { id = 4, departmentName = "Finance" }

            };

            var qs = (from emp in dataSource
                      join dept in dataSource1
                      on -emp.id equals dept.id
                      select new
                      {
                          empName = emp.name,
                          deptName = dept.departmentName
                      }).ToList();
           

            foreach (var em in qs)
            {
                Console.WriteLine("EmpName " + em.empName + "Department Name " + em.deptName);
              
            }

         }
    }
        class Employee
        {
            public int id { get; set; }
          public string name { get; set; }
            public string address { get; set; }
       
        }
        class Department
        {
            public int id { get; set; }
            public string departmentName { get; set; }

        }
        
    
}
