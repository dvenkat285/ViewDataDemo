using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDataDemo.Models;

namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = "Message from View Data !!";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            string[] Fruits = { "Apple", "Banana", "Grapes", "Orange" };
            ViewData["FruitsArray"] = Fruits;

            ViewData["SportsList"] = new List<string>()
            {
                "Cricket",
                "Hockey",
                "Football",
                "Volley Ball"
            };

            Employee Ali = new Employee();
            Ali.EmpID = 11;
            Ali.EmpName = "Ali Khan";
            Ali.EmpDesignation = "Manager";

            ViewData["Employee"] = Ali;

            return View();
        }
    }
}