using System;
using System.Linq;
using System.Collections.Generic;
using DemoProjectRajdeep.Models;


namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> em = Employee.GetEmployees();
            //var result = em.GroupBy(x => x.City);
            //foreach(var item in result)
            //{
            //    Console.Write(item.Key + " " + item.Count());
            //}

            //  Console.WriteLine("Hello World!");
            List<Employee> employees = new List<Employee>()
            {
               new Employee() { Id = 1, Name = "idris", City = "Noida", Country = "India" },
           new Employee() { Id = 2, Name = "Shristi", City = "Mohali", Country = "India" },
            new Employee() { Id = 3, Name = "Umar", City = "Mohali", Country = "India" },
           new Employee() { Id = 4, Name = "Iram", City = "Lucknow", Country = "India" },
           new Employee() { Id = 5, Name = "Madiha", City = "Noida", Country = "India" }
             };
            List<Project> projects = new List<Project>()
            {
                  new Project(){id=1,ProjectName="Microsoft",ProjectCity="Mohali"},
                  new Project(){id=2,ProjectName=".Net",ProjectCity="Lucknow"},
                  new Project(){id=3,ProjectName="java",ProjectCity="Noida"}

            };
            var result = from e in employees
                         join p in projects
                         on e.City equals p.ProjectCity
                         select new
                         {
                             name = e.Name,
                             city = p.ProjectCity
                         };
            foreach(var item in result)
            {
                Console.WriteLine(item.name + "-------------" + item.city);
                Console.WriteLine();
            }
           

            Console.ReadKey();
        }
    }
}
