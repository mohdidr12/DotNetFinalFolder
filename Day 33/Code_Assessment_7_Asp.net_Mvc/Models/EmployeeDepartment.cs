using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Code_Assessment_7_Asp.net_Mvc.Models
{
    public class EmployeeDepartment : DbContext
    {
      public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}