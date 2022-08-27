using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
namespace EasyCRM.DAL.Entity
{
    public class Users IdentityUser {    
        [Required]
    public string Name { get; set; }

    [Required]
    public string Address{ get;set;}

   [Required]
public string Gender { get; set; }    
    }    
} 
