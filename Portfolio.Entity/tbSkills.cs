using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entity
{
    [Table("tbSkills")]
    public partial class tbSkills
    {
        [Key]
        public int Id { get; set; }
        public string cTechnology { get; set; }
        public int cKnowledge { get; set; }

        public int? UserId { get; set; }
        public virtual tbUser tbUser { get; set; }

    }
}
