using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class StringAndMathController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult DifferenceCalc(String lastName, int age)
        {
            int nameLength = lastName.Length;
            int num = Math.Abs(nameLength - age);
            return View(viewName: "Index", model: num);
        }
    }
}