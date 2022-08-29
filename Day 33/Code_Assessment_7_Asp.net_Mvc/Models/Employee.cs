using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Code_Assessment_7_Asp.net_Mvc.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Employee Name is Mandatory")]
        [StringLength(40, ErrorMessage = "cannot accept more than 40 alphabets")]
        [RegularExpression("^([a-zA-Z .&'-]+)$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Name should contain atleast 3 characters")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Gender is Mandatory")]
        [StringLength(40, ErrorMessage = "cannot accept more than 40 alphabets")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "City is Mandatory")]
        [StringLength(40, ErrorMessage = "cannot accept more than 40 alphabets")]
        public string City { get; set; }
        [Required(ErrorMessage = "Salary is Mandatory")]
        [RegularExpression(@"^\d+(\.\d{2})?$", ErrorMessage = "Invalid Salary.")]
        public double Salary { get; set; }
        public virtual Department department { get; set; }
        public int DepartmentId { get; set; }
    }
}