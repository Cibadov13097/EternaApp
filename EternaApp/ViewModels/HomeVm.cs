using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class HomeVm
    {
        public List<HomeSlider> homeSliders { get; set; }

        public List<Feature> Features { get; set; }

        public List<Service> Services { get; set; }

        public List<Client>  Clients { get; set; }
    }
}
