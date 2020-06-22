using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class DatesActivityController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0.0);
        }
        [HttpPost]
        public ActionResult DateMagic(DateTime inputBirthday)
        {
            var today = DateTime.Today;
            // Calculate the age.
            DateTime birthdate = inputBirthday;
            var age = today.Subtract(birthdate).TotalDays;

            var years = (age / 365);

            age = (int)(Math.Round(years));
            return View(viewName: "Index", model: age);
        }

    }
}