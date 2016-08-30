using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Portfolio.BL.BindStrategy.ApiBind;
using Portfolio.UIModels.ApiModels;

namespace Portfolio.WebUI.Controllers
{
    public class MobileWebApiAuthController: ApiController
    {
        public IEnumerable<MobileWebApiAuthorizedUserModel> Post()// Auth at this shit
        {
            MobileWebApiAuthorizedUserBind binder = new MobileWebApiAuthorizedUserBind();
            var res = binder.BindData();

            return (res);

        }
    }
}