using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.UIModels.ApiModels
{
    public class MobileWebApiUserWorkModel
    {
        public int IdUser { get; set; }
        public string UserCompany { get; set; }
        public string UserStanding { get; set; }
        public DateTime CompanyStartPeriod { get; set; }
        public DateTime CompanyEndPeriod { get; set; }
        public string CompanyDescription { get; set; }



    }
}
