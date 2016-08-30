using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entity
{   
    [Table("tbLanguages")]
    public partial class tbLanguages 
    {
        [Key]
        public int cId { get; set; }
        public string cLanguage { get; set; }
        public string cLevel { get; set; }

        public int? UserId { get; set; }
        public virtual tbUser tbUser { get; set; }
    }
}
