using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        public ActionResult Index() {
            return View();
        }

        //public string Index() {
        //    return "This is my <b>default</b> action...";
        //}

            //get:HelloWorld/Welcome
            //public string Welcome() {
            //    return "This is the Welcome action method...";
            //}

            //public string Welcome(int numTimes, string name) {
            //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
            //}

        public ActionResult Welcome(string name = "Leo Scherhag", int NumTimes = 9) {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = NumTimes;
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);

            return View("Welcome");
        }

        public ActionResult WelcomeFun() {
            //ViewBag.Message = "Hello " + name;
            //ViewBag.NumTimes = NumTimes;
            ////return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);

            //return View("Welcome");

            return Welcome("Jürgen Fun", 5);
        }
    }
}