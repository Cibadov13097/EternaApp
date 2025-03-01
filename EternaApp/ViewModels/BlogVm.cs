using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class BlogVm
    {
        public List<Blog>  Blogs { get; set; }
        public List<BlogDetail> BlogDetails { get; set; }
        public List<Message> Messages { get; set; }

    }
}
