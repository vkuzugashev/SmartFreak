using SmartFreakApp.Models;
using SmartFreakLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SF=SmartFreakLib;

namespace SmartFreakApp.Controllers
{
    public class HomeController : Controller
    {
        Model model = new Model();

        public ActionResult Index()
        {
            return View(model.app.View.Pages.Find(x=>x.Name=="main"));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}