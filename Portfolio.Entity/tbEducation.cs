using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entity
{
    [Table("tbEducation")]
    public partial class tbEducation
    {
        [Key]
       
        public int cId { get; set; }
        public string cName { get; set; }
        public string cPlace { get; set; }

        public DateTime cStartPeriod { get; set; }
        public DateTime cEndPeriod { get; set; }


        public int? UserId { get; set; }
        public virtual tbUser tbUser { get; set; }
    }
}
