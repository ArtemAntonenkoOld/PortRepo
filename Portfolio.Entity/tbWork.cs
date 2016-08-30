using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entity
{   
    [Table("tbWork")]
    public partial class tbWork
    {
        [Key]
        public int cId { get;set;}
        public string cCompany { get; set; }
        public string cStanding { get; set; }
        public DateTime cStartPeriod { get; set; }
        public DateTime cEndPeriod { get; set; }
        public string cDescription { get; set; }

        public int? UserId { get; set; }
        public virtual tbUser tbUser { get; set; }
    }
}
