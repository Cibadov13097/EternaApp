using System.Diagnostics.CodeAnalysis;

namespace EternaApp.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string MessageText { get; set; }
        public string SenderName { get; set; }

        public string SenderImage { get; set; }

        public int? RepliedMessageId { get; set; }
        public int BlogDetailId { get; set; }
        public BlogDetail BlogDetail { get; set; }
    
    }
}
