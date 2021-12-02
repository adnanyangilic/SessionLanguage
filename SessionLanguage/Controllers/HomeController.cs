using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SessionLanguage.Models;

namespace SessionLanguage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["Langses"]==null)Session.Add("Langses", 1);
           
            ViewBag.Langses = Session["Langses"];
            return View();
        }


        [HttpPost]
        public ActionResult Index(string langsesstr)
        {
           
            Session["Langses"] = langsesstr;

            ViewBag.Langses = null;
            var langses = 0;
            if (langsesstr == "ar") { langses = 8; }
            else if (langsesstr == "tr") { langses = 1; }
            else if (langsesstr == "en") { langses = 2; }
            else if (langsesstr == "ch") { langses = 7; }
            else if (langsesstr == "fr") { langses = 3; }
            else if (langsesstr == "es") { langses = 6; }
            else if (langsesstr == "de") { langses = 4; }
            else if (langsesstr == "ru") { langses = 5; }
            Session["Langses"] = langses;

            var res = ViewBag.Langses = Session["Langses"];
            var rescont = res;
            return View();

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