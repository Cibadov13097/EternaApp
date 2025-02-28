namespace EternaApp.Models
{
    public class ProjectImages
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public string Image { get; set; }
    
        public Project Project { get; set; }
        
    }
}
