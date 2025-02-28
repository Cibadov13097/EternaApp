using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Controllers
{
    public class PortfolioController : Controller
    {

        private readonly EternaAppContext _context;

        public PortfolioController(EternaAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var projects = _context.Projects.Include(p => p.ProjectImages).Include(p => p.Category).ToList();
            var projectImgs= _context.ProjectImages.ToList();
            var category = _context.Categories.ToList();

            PortfolioVm portfolioVm = new PortfolioVm()
            {
                projects = projects,
                projectImgs = projectImgs,
                categories= category
            };

            return View(portfolioVm);
        }
        public IActionResult Detail(int id)
        {
            ViewBag.Id = id;

            var projects = _context.Projects.Include(p => p.ProjectImages).Include(p => p.Category).ToList();
            var projectImgs = _context.ProjectImages.ToList();
            var category = _context.Categories.ToList();

            PortfolioVm portfolioVm = new PortfolioVm()
            {
                projects = projects,
                projectImgs = projectImgs,
                categories = category
            };

            return View(portfolioVm);
        }
    }
}
