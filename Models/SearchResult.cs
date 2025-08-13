namespace PentaNest.Emlak.Api.Models
{
    public class Meta
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public int TotalPages { get; set; }
    }

    public class SearchResult
    {
        public Meta Meta { get; set; } = new Meta();
        public IEnumerable<Property> Data { get; set; } = new List<Property>();
    }
}