﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Portfolio.BL.BindStrategy.ApiBind;
using Portfolio.UIModels.ApiModels;
namespace Portfolio.WebUI.Controllers
{
    public class MobileWebApiSearchController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<MobileWebApiSearchModel> Post(string SearchRequest)// or get mathod
        {
            MobileWebApiSearchBind binder = new MobileWebApiSearchBind();
            var res = binder.BindData(SearchRequest);

            return (res);

        }


    }
}