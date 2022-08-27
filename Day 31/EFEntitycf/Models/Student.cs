using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFEntitycf.Models
{
    public class Student
    {
        [Key]
        [Required(ErrorMessage = "Student id is required")]
        public int Id { get; set; }

        
       
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}