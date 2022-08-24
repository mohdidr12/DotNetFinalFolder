using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCdemo4.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}