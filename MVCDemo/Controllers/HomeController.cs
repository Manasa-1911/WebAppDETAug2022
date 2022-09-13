using Microsoft.AspNetCore.Mvc;
using MVCDemo.Filter;
using MVCDemo.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Helo(string name,string loc,string contact)
        {
            ViewBag.UserName = name;
            ViewBag.Location = loc;
            ViewBag.Contact = contact;
            return View();
        }

        [MyLog]
        public string[] retests()
        {
            return new string[] { "C#=12-Sep", "Tsql=13-Sep" };
        }

        public IActionResult Index()
        {
            return View();
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