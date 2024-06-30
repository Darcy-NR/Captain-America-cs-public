using CaptainAmerica.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CaptainAmerica.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult GenerateCoverLetter(string location, string position, string company, int aboutMeType)
        {
            Role role = new Role(location, position, company);
            string coverLetter = CoverLetter.MakeCoverLetter(role, aboutMeType);
            ViewBag.CoverLetter = coverLetter;

            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}