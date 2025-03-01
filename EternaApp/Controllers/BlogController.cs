using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Controllers
{
    public class BlogController : Controller
    {

        private readonly EternaAppContext _context;

        public BlogController(EternaAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var blog = _context.Blogs.Include(b => b.BlogDetail).ToList();
            var blogdetails = _context.BlogDetails.Include(bd => bd.Messages).ToList();
            var messages = _context.Messages.ToList();

            BlogVm blogVm = new BlogVm()
            {
                Blogs = blog,
                BlogDetails = blogdetails,
                Messages = messages
            };

            return View(blogVm);
        }

        public IActionResult Detail(int id)
        {

          var blog=  _context.Blogs.Include(b => b.BlogDetail).ToList();
           var blogdetails= _context.BlogDetails.Include(bd => bd.Messages).ToList();
           var messages= _context.Messages.ToList();

            BlogVm blogVm = new BlogVm()
            {
                Blogs = blog,
                BlogDetails = blogdetails,
                Messages = messages
            };
            ViewBag.id = id;
            return View(blogVm);
        }
    }
}
