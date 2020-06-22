using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class DatesController : Controller
    {
        // GET: Dates
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult DateMagic(DateTime inputBirthday)
        {
            int birthYear = inputBirthday.Year;
            /*int nextElectionYear = DateTime.Now.Year;
            while(nextElectionYear % 4 != 0)
            {
                nextElectionYear++;
            }
            birthYear = nextElectionYear - birthYear;
            */

            int numOfLeapYearsPassedSinceBirth = 0;
            for(int year = birthYear; year <= DateTime.Now.Year; year++)
            {
                if(year % 4 == 0)
                {
                    numOfLeapYearsPassedSinceBirth++;
                }
            }
            return View(viewName: "Index", model: numOfLeapYearsPassedSinceBirth);
        }
    }
}