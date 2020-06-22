using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class MagicNumberController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0.0);
        }
        [HttpPost]
        public ActionResult GetNumbers(int inputNumber1, int inputNumber2)
        {
            int area = Math.Max(inputNumber1, inputNumber2) - Math.Min(inputNumber1, inputNumber2);
            Random rand = new Random();
            int num = (int)((rand.NextDouble()) * area);
            num += Math.Min(inputNumber1, inputNumber2);
            return View(viewName: "Index", model: (num));
        }
    }
}