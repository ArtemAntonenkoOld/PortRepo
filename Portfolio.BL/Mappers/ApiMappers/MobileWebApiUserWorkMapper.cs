using Portfolio.Entity;
using Portfolio.UIModels.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.BL.Mappers.BaseMappers;


namespace Portfolio.BL.Mappers.ApiMappers
{
    public class MobileWebApiUserWorkMapper
    {
        public MobileWebApiUserWorkModel EntityToModel(tbWork model)
        {
            MobileWebApiUserWorkModel prop = new MobileWebApiUserWorkModel();
            prop.IdUser = model.tbUser.cId;
            prop.UserCompany = model.cCompany;
            prop.CompanyDescription = model.cDescription;
            prop.CompanyEndPeriod = model.cEndPeriod;
            prop.CompanyStartPeriod = model.cStartPeriod; 


            return prop;
        }
    }
}
