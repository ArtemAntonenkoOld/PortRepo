using Portfolio.BL.BindStrategy.ViewBind;
using Portfolio.UIModels.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Portfolio.WebUI.Controllers
{
    public class UserController : Controller
    {
       public ActionResult Resume(int id)
        {
            ResumeViewBind binder = new ResumeViewBind();
            IEnumerable<ResumePageModel> res = binder.BindFromEntities(id) as
                  IEnumerable<ResumePageModel>;

            //var res = binder.BindFromEntities(id).FirstOrDefault(); 
            if (res.Count() == 0)
            {
                return View("Index");
            }
            else {
                var a = res.FirstOrDefault().Design;
                return View(a + "/Index", res);
            }
        }

       
    }
}