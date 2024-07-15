using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BootstrapProto.Data;
using BootstrapProto.Models;
using BootstrapProto.Models.Entities;
using System.Diagnostics;

namespace BootstrapProto.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly ILogger<WorkoutController> _logger;
        private readonly ApplicationDbContext _context;
        public WorkoutController(ILogger<WorkoutController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this._context = context;
        }

        public IActionResult CurrentProgramWorkout()
        {
            return View();
        }
        public async Task <IActionResult> SelectExercise(int id)
                                                                                                                                                  {   var bodypart =await  _context.BodyParts.Where(x=>x.BodyPartId==id).ToListAsync();
            var excercises = await _context.Excercises.Where(x => x.BodyPartID == id).ToListAsync();
            var warmups = await  _context.Warm_Ups.Where(x => x.BodyPartID == id).ToListAsync();
            var tuple = new Tuple<List<Excercise>,List<Warm_Ups>, List<BodyPart>>(new List<Excercise>(excercises),new List<Warm_Ups>(warmups), new List<BodyPart>(bodypart));
            return View(tuple);
        }
        public async Task<IActionResult> BodyPartSelect()
        {
            var bodyParts =await _context.BodyParts.ToListAsync();
           
            return View(bodyParts);

        }

        public IActionResult SelectTeamAndPreview()
        {
            return View();
        }
        public IActionResult WorkoutNav()
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
