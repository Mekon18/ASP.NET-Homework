using Asp.net_MVC_13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.net_MVC_13.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Calc c = Calc.Create();

            return View(c);
        }

        [HttpPost]
        public ActionResult Index(Calc calc)
        {

            double result = 0;
            switch (calc.Operation)
            {
                case "+": result = calc.Arg1 + calc.Arg2; break;
                case "-": result = calc.Arg1 - calc.Arg2; break;
                case "*": result = calc.Arg1 * calc.Arg2; break;

            }
            if (calc.Result == result)
                ViewBag.Message = "Correct";
            else
                ViewBag.Message = "Wrong";
            Calc c = Calc.Create();
            ModelState.Clear();
            return View(c);
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