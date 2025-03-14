﻿namespace EternaApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublishedTime { get; set; }
        public BlogDetail BlogDetail { get; set; }
    }
}
