using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DemoProjectRajdeep.Models
{
    public class Employee
    {
        [Key]
        [Required(ErrorMessage = "Id is Mandatory")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage = "City is Mandatory")]
        public string City { get; set; }
        [Required(ErrorMessage = "Country is Mandatory")]
        public string Country { get; set; }
        
      
        //public static List<Employee>  GetEmployees()
        //{
        //    List<Employee> emp = new List<Employee>();
        //    Employee e1 = new Employee() { Id = 1, Name = "idris", City = "jaipur", Country = "India" };
        //    Employee e2 = new Employee() { Id = 2, Name = "Shristi", City = "Ajmer", Country = "India" };
        //    Employee e3 = new Employee() { Id = 3, Name = "Umar", City = "jaipur", Country = "India" };
        //    Employee e4 = new Employee() { Id = 4, Name = "Iram", City = "Ajmer", Country = "India" };
        //    Employee e5 = new Employee() { Id = 5, Name = "Madiha", City = "Ajmer", Country = "India" };
        //    emp.Add(e1);
        //    emp.Add(e2);
        //    emp.Add(e3);
            
        //    return emp;
        //}
       //public static void CreateEmp(Employee e)
       // {
       //     GetEmployees().Add(e);
       // }
     }
   }