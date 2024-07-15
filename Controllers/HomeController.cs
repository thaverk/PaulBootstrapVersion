using Microsoft.AspNetCore.Mvc;
using BootstrapProto.Models;
using System.Diagnostics;

namespace BootstrapProto.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult CurrentProgramWorkout()
        {
            return View();
        }
        public IActionResult SelectExercise()
        {
            return View();
        }
        public IActionResult BodyPartSelect()
        {
            return View();
        }

        public IActionResult SelectTeamAndPreview()
        {
            return View();
        }

        public IActionResult PhysioCP()
        {
            return View();
        }
        public IActionResult SelectAthlete()
        {
            return View();
        }

        

        public IActionResult CustomProgram()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel{ RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
