using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PracticeCategoryProductEF.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is Mandatory")]
        [StringLength(40, ErrorMessage = "cannot accept more than 40 alphabets")]
        [RegularExpression("^[a-zA-Zs]+$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Name should contain atleast 3 characters")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Price is Mandatory")]
        [RegularExpression(@"^\d+(\.\d{2})?$", ErrorMessage = "Invalid price.")]
        public double Price { get; set; }
        public virtual Category category { get; set; }
        public int CategoryId { get; set; }
    }
}