
using EternaApp.Models;
using Microsoft.EntityFrameworkCore;
namespace EternaApp.Data
{
    public class EternaAppContext:DbContext
    {

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<HomeSlider> HomeSliders { get;set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Skills> Skills { get; set; }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImages> ProjectImages { get; set; }
        public DbSet<Category> Categories { get; set; }

        public EternaAppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }
    }
}
