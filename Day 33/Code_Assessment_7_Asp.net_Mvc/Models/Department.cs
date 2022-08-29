using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Code_Assessment_7_Asp.net_Mvc.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Department Name is mandatory")]
        [StringLength(40, ErrorMessage = "cannot accept more than 40 alphabets")]
        [RegularExpression("^([a-zA-Z .&'-]+)$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Name should contain atleast 3 characters")]
        public string DepartmentName { get; set; }
    }
}