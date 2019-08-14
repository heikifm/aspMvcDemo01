using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo01.Models;

namespace demo01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "morning!" : "afternoon!";
            return View();
        }

        [HttpGet]
        public ViewResult TestForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult TestForm(MemberResponse memberResponse)
        {
            if (ModelState.IsValid)
            {
                return View("demoView", memberResponse);
            }
            else
            {
                return View();
            }
            
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

        public string Jung()
        {
            return "Uaaaaaaaaaa";
        }

        public string Test()
        {
            return "This is test!!!!";
        }

        public string Jung1()
        {
            return "Ubbbbbbbbb";
        }

        public string Test2()
        {
            return "This is test????";
        }
    }
}