using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Core.Model;
using Homepage.MVC.Models;

namespace Homepage.MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMail(string subject,string message, string email)
        {
            try
            {
                Email mail = new Email(subject, message, email);
                mail.sendMail();
            }
            catch (Exception ex)
            {

                ViewBag.EmailError = ex.Message;
            }
            ViewBag.SendMail = true;


            return View("Index");
        }

    }
}
