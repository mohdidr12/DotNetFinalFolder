using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Real.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<decimal> Salary { get; set; }
    }
}