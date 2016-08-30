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
    public class MobileWebApiSearchMapper
    {
        public MobileWebApiSearchModel EntityToModel(tbUser model)
        {
            MobileWebApiSearchModel p = new MobileWebApiSearchModel();

            p.UserId = model.cId;
            p.UserName = model.cName;
            p.UserPosition = model.cPosition;
            p.UserSurname = model.cSurname;
            

            return p;
        }
    }
}