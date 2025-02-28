using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class ServiceController : Controller
    {

        private readonly EternaAppContext _context;

        public ServiceController(EternaAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var services=_context.Services.ToList();
            var skills=_context.Skills.ToList();

            ServicesVm servicesVm = new ServicesVm()
            {
                Services = services,
                Skills = skills
            };


            return View(servicesVm);
        }
    }
}
