using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CategoryProductCodeFirstTask.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category Name is mandatory")]
        [StringLength(40,ErrorMessage ="cannot accept more than 40 alphabets")]
        [RegularExpression("^[a-zA-Zs]+$",ErrorMessage ="Invalid Name")]
        [MinLength(3,ErrorMessage ="Name should contain atleast 3 characters")]
        public string CategoryName { get; set; }
    }
}