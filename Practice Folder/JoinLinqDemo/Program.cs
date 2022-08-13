using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //    var dataSource = new List<Employee>()
            //    {
            //    new Employee(){id=1,name="idris",address="jaipur"},
            //    new Employee() { id = 2, name = "Juned", address = "Ajmer" },
            //    new Employee() { id = 3, name = "Jaanvi", address = "Kota" },
            //    new Employee() { id = 4, name = "Aamir", address = "Jabalpur" }
            //    };
            //    var dataSource1 = new List<Department>()
            //    {
            //         new Department(){Id=1,address="jaipur",departmentName="IT"},
            //         new Department(){Id=2,address="Ajmer",departmentName="Finance"},
            //         new Department(){Id=3,address="Kota",departmentName="IT"},
            //         new Department(){Id=4,address="Jabalpur", departmentName = "Finance" }

            //    };

            //    var qs = (from emp in dataSource
            //              join dept in dataSource1
            //              on emp.id equals dept.Id
            //              select new
            //              {
            //                  empName = emp.name,
            //                  deptName = dept.departmentName
            //              }).ToList();


            //    foreach (var em in qs)
            //    {
            //        Console.WriteLine("EmpName is  " + em.empName +","+ "Department Name " + em.deptName);

            //    }
            //

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var ms = arr.FirstOrDefault(x => x > 10);
            Console.ReadLine();
        }
    }  
}
