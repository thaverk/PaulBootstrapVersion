using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BootstrapProto.Data;
using BootstrapProto.Models;
using BootstrapProto.Models.Entities;

namespace BootstrapProto.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext databaseContext;
        public UsersController(ApplicationDbContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserVM userVM)
        {
            var user = new User
            {
                UserName = userVM.UserName,
                UserEmail = userVM.UserEmail,
                UserPassword = userVM.UserPassword,
                UserTeam = userVM.UserTeam,
                UserJersey = userVM.UserJersey,
            };
            await databaseContext.Users.AddAsync(user);
            await databaseContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var athlete = await databaseContext.Users.ToListAsync();
            return View(athlete);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var athlete = await databaseContext.Users.FindAsync(id);
            return View(athlete);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(User view)
        {
            var athlete = await databaseContext.Users.FindAsync(view.Id);
            if (athlete is not null)
            {
                athlete.UserName = view.UserName;
                athlete.UserPic = view.UserPic;
                athlete.UserPassword = view.UserPassword;
                athlete.UserEmail = view.UserEmail;
                athlete.UserJersey = view.UserJersey;
                athlete.UserTeam = view.UserTeam;

                await databaseContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Users");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var athete = await databaseContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (athete is not null)
            {
                databaseContext.Users.Remove(athete);
                await databaseContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Users");




        }
    }
}
