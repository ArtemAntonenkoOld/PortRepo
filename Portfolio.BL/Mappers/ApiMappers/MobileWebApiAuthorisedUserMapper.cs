using Portfolio.Entity;
using Portfolio.UIModels.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BL.Mappers.ApiMappers
{
    public class MobileWebApiAuthorisedUserMapper
    {

        public MobileWebApiAuthorizedUserModel EntityToModel(tbUser model)
        {
            MobileWebApiAuthorizedUserModel p = new MobileWebApiAuthorizedUserModel();

            p.UserId = model.cId;
            p.UserName = model.cName;
            p.UserPosition = model.cPosition;
            p.UserSurname = model.cSurname;
            p.UserAge = model.cAge;
            p.UserCity = model.cCity;
            p.UserDesign = model.cDesign;
            p.UserPhone = model.cPhone;
            p.UserPhoto = model.cPhoto;
            
            

            return p;
        }
    }
}

