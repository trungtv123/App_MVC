using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult trangchu()
        {
            return View();
        }

        public ActionResult gioithieu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult lienhe()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}