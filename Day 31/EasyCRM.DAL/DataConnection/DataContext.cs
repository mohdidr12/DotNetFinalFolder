using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCRM.DAL.Entity;
using EasyCRM.DAL.Entity.Customer;
using EasyCRM.DAL.DataConnection;
using Microsoft.AspNet.Identity.EntityFramework;


namespace EasyCRM.DAL.DataConnection
{
    public class DataContext IdentityDbContext<Users> {    
        public DataContext() base("DefaultConnection") { }
    

public DbSet<Customer_PersonalDetail> Customer_PersonalDetail { get; set; }    
    }    
} 
