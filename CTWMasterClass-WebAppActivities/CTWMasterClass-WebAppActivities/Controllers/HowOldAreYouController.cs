using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class HowOldAreYouController : Controller
    {
        // GET: HowOldAreYou
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }

        public ActionResult birthdayToString(DateTime inputBirthday)
        {
            TimeSpan time = DateTime.Now - inputBirthday;
            int age = time.Days / 365;
            return View(viewName: "Index", model: age);
        }
    }
}