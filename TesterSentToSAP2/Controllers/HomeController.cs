using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hangfire;
using TesterSentToSAP2.Class;

namespace TesterSentToSAP2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public void test() 
        {
            Test a = new Test();

            a.testTxt();
        }

        [HttpGet]
        public string RunBackground()
        {
            try
            {
                BackgroundJob.Enqueue(() => test());

                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
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