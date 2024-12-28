using MyElearning.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearning.Controllers
{
    public class AboutController : Controller
    {
       ElearningContext context=new ElearningContext();
        public ActionResult Index()
        {
        var values=context.Abouts.ToList();
            return View(values);
        }
    }
}