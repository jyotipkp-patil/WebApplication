using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            employee model = new employee();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(employee emp)
        {
            StringBuilder sbInterest = new StringBuilder();
            sbInterest.Append("<b>FName :</b> " + emp.FName + "<br/>");
            sbInterest.Append("<b>LName :</b> " + emp.Lname + "<br/>");
            sbInterest.Append("<b>AGE(year) :</b> " + emp.AGE + "<br/>");
            return Content(sbInterest.ToString());
        }
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
