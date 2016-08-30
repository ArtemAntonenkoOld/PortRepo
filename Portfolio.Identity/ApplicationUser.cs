using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Portfolio.Entity;

namespace Portfolio.Identity
{
    
    public class ApplicationUser : IdentityUser
    {
        public int Year { get; set; }
        
        public ApplicationUser()
        {
        }
    }
}
