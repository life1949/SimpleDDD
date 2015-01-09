using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleDDD.Sample.Controllers
{
    public class WeekReportController : Controller
    {
        //
        // GET: /WeekReport/

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}
