using ControllerTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(Message m)
        {
            //return string.Format("Otrzymałeś wiadomość od {0}, temat: {1}, wiadomość: {2}.",
            //    m.Email, m.Topic, m.Text);

            return View("EmailConfirmation",m);

        }
    }
}