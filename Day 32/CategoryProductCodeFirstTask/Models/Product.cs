using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CategoryProductCodeFirstTask.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public virtual Category category { get; set; }
        public int CategoryId { get; set; }
    }
}