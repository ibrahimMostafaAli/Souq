using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SouqApp.Models;
namespace SouqApp.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        SouqDBDataContext DB = new SouqDBDataContext();

        public ActionResult Index()
        {
            var Result = from p in DB.Products
                         select p;
            return View(Result);
        }
    }
}