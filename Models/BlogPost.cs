namespace PentaNest.Emlak.Api.Models
{
    public class BlogPost
    {
        public required string Slug { get; set; }
        public required string Author { get; set; }
        public required string Date { get; set; }
        public required string Title { get; set; }
        public required string Image { get; set; }
        public required string Snippet { get; set; }
        public required string FullContent { get; set; }
    }
}