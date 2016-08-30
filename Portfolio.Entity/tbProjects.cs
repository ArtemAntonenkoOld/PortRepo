using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entity
{
    [Table ("tbProjects")]
    public partial class tbProjects
    {
        [Key]
       
        public int cId { get; set; }
        public string cName { get; set; }
        public string cLink { get; set; }
        public string cDescription { get; set; }
        public string cCompany { get; set; }

        public int? UserId { get; set; }
        public virtual tbUser tbUser { get; set; }

    }
}
