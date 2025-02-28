namespace EternaApp.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Client { get; set; }
        public List<ProjectImages> ProjectImages  { get; set; }
        public DateTime ProjectDate { get; set; }
        public string ProjectURL { get; set; }
        public Category Category { get; set; }
    }

}
