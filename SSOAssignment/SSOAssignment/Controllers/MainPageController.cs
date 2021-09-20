using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSOAssignment.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult Index()
        {
            return View();
        }

        public string MainAppPage()
        {
            return "This is the main page";
        }

        public string InitialTest(string name)
        {
            return "Test succesful," + name;
        }
    }
}