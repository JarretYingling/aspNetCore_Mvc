using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspNetCore_Mvc.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspNetCore_Mvc.Controllers
{
    public class AppController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string param_01, string param_02)
        {
            ViewData["FirstName"] = "Jarret";
            ViewData["LastName"] = "Yingling";
            ViewData["PageName"] = "Index";
            ViewData["Message"] = "Index View has access to key:value pairs in Controller";
            ViewData["Parameter_01"] = param_01;
            ViewData["Parameter_02"] = param_02;
            return View();
        }

        public IActionResult About(string param_01, string param_02)
        {
            ViewData["PageName"] = "About";
            ViewData["Message"] = "About View has access to key:value pairs in Controller";
            ViewData["Parameter_01"] = param_01;
            ViewData["Parameter_02"] = param_02;
            return View();
        }

        public IActionResult Contact(string param_01, string param_02)
        {
            ViewData["PageName"] = "Contact";
            ViewData["Message"] = "Contact View has access to key:value pairs in Controller";
            ViewData["Parameter_01"] = param_01;
            ViewData["Parameter_02"] = param_02;
            return View();
        }

        public IActionResult Privacy(string param_01, string param_02)
        {
            ViewData["PageName"] = "Privacy";
            ViewData["Message"] = "Privacy View has access to key:value pairs in Controller";
            ViewData["Parameter_01"] = param_01;
            ViewData["Parameter_02"] = param_02;
            return View();
        }

        public string Route_01()
        {
            return "Route 01";
        }

        public string Route_02()
        {
            return "Route 02";
        }
    }
}
