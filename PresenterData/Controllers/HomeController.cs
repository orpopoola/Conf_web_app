using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresenterData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Subindex()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "UPEC 2018 Presentation and paper grading application.";

            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact UPEC 2018.";

            return View();
        }
    }
}