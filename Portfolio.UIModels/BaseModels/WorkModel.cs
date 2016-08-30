using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.UIModels.BaseModels
{
    public class WorkModel
    {
        public int Id { get;set;}
        public string Company { get; set; }
        public string Standing { get; set; }
        public string Description { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        
    }
}
