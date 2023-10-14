using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_thu_cung_.Controllers
{
    public class DemoLayoutController : Controller
    {
        // GET: DemoLayout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}