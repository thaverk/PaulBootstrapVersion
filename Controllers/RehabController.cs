using Microsoft.AspNetCore.Mvc;
using BootstrapProto.Models;
using System.Diagnostics;

namespace BootstrapProto.Controllers
{
    public class RehabController: Controller
    {
        private readonly ILogger<RehabController> _logger;

        public RehabController(ILogger<RehabController> logger)
        {
            _logger = logger;
        }

        public IActionResult BuildProgram()
        {
            return View();
        }

        public IActionResult AthleteName()
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


        public IActionResult Preview()
        {
            return View();
        }

        public IActionResult CustomProgram()
        {
            return View();
        }

        public IActionResult RehabNav()
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
