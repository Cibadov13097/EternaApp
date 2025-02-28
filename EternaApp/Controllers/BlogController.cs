using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
