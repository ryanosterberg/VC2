using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class StringAndMathController : Controller
    {
        // GET: StringAndMath
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult DateMagic(int age, string lastName)
        {
            int charsInLastName = lastName.Length;
            int difference = Math.Abs(age - charsInLastName);
            return View(viewName: "Index", model: difference);
        }
    }
}