using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Entity
{
    [Table("tbUser")]
    public partial class tbUser
    {
        
        [Key]
        public int cId { get; set; }
        public string cName { get; set; }
        public string cSurname { get; set; }
        public string cEmail { get; set; }
        public string cPosition { get; set; }
        public string cDescription { get; set; }
        public int cAge { get; set; }
        public int cPhone { get; set; }
        public string cCity { get; set; }
        public string cDesign { get; set; }
        public byte[] cPhoto { get; set; }
        public virtual ICollection<tbWork> tbWork { get; set; }
        public virtual ICollection<tbSkills> tbSkills { get; set; }
        public virtual ICollection<tbProjects> tbProjects { get; set; }
        public virtual ICollection<tbLanguages> tbLanguages { get; set; }
        public virtual ICollection<tbEducation> tbEducation { get; set; }
    }
}
