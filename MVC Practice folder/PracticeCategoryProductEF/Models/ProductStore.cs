using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PracticeCategoryProductEF.Models
{
    public class ProductStore : DbContext
    {
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().MapToStoredProcedures();
            modelBuilder.Entity<Product>().MapToStoredProcedures();
            
            base.OnModelCreating(modelBuilder);
        }
     
    }
    
}