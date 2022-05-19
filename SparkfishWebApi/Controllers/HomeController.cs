using SparkfishWebApi.Models;
using SparkfishWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SparkfishWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        
        public ActionResult Documentation()
        {
            ViewBag.Title = "Documentation Page";

            return View();
        }

        public ActionResult TestInput()
        {
            return View(new IncomingListifyModel());
        }

        [HttpPost]
        public JsonResult TestResult(IncomingListifyModel model)
        {
            int result = new Listify<int>().IndexOfRange(Enumerable.Range(model.Min, model.Max), model.Index);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
