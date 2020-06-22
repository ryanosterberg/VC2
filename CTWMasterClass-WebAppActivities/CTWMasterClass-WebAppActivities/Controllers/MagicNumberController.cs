using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class MagicNumberController : Controller
    {
        // GET: MagicNumber
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult MagicNumber(int inputNumber, int inputNumber2)
        {
            Random rand = new Random();
            int magicNumber;
            if (inputNumber2 > inputNumber)
            {
                magicNumber = rand.Next(inputNumber, inputNumber2);
            }
            else
            {
                magicNumber = rand.Next(inputNumber2, inputNumber);
            }
            return View(viewName: "Index", model: magicNumber);
        }
    }
}