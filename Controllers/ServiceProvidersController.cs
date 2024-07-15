using Microsoft.AspNetCore.Mvc;
using BootstrapProto.Data;
using BootstrapProto.Models.Entities;
using BootstrapProto.Models;

namespace BootstrapProto.Controllers
{
    public class ServiceProvidersController : Controller
    {
        private readonly ApplicationDbContext databaseContext;
        public ServiceProvidersController(ApplicationDbContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signin(ProviderVM providerVM)
        {
            var provider = new Provider
            {
                SPName = providerVM.SPName,
                SPType = providerVM.SPType,
            };
            await databaseContext.ServiceProviders.AddAsync(provider);
            await databaseContext.SaveChangesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(ProviderVM providerVM)
        {
            var provider = new Provider
            {
                SPName = providerVM.SPName,
                SPType = providerVM.SPType,
            };
            await databaseContext.ServiceProviders.AddAsync(provider);
            await databaseContext.SaveChangesAsync();
            return View();
        }
    }
}
