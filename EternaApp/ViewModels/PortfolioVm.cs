using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class PortfolioVm
    {
        public List<Project> projects { get; set; }
        public List<ProjectImages> projectImgs { get; set; }
        public List<Category> categories { get; set; }
    }
}
