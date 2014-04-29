using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homepage.MVC.Controllers
{
    public class LayoutController : Controller
    {
        //
        // GET: /Layout/

        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult Footer()
        {
            return View();
        }
    }
}
