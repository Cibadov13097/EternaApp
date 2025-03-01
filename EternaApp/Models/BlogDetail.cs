namespace EternaApp.Models
{
    public class BlogDetail
    {
        public  int Id { get; set; }

        public string paragraph { get; set; }

        public string Image   { get; set; }

        public int BlogId { get; set; }
        public List<Message> Messages { get; set; }

        public Blog Blog { get; set; }

    }
}
