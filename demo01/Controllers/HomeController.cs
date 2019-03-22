using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        // GET: Home
        //public string Index()
        //{
        //    return "Hello world!";
        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}