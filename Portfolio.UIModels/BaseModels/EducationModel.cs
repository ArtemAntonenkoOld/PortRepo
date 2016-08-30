using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.UIModels.BaseModels
{
    public class EducationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }

    }
}
