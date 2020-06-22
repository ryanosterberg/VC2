using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class SquareANumberController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult SaySquare(int inputNumber)
        {
            return View(viewName: "Index", model: (inputNumber * inputNumber));
        }


    }
}