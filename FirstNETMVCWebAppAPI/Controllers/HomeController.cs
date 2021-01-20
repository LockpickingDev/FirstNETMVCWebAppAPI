using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstNETMVCWebAppAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Load Index.cshtml View
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
