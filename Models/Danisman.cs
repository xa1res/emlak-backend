namespace PentaNest.Emlak.Api.Models
{
    public class Danisman
    {
        public required string Foto { get; set; }
        public required string Url { get; set; }
        public required string Isim { get; set; }
        public required string Hakkimda { get; set; }
        public required string Telefon { get; set; }
        public required string Mail { get; set; }
        public required string Instagram { get; set; }
        public required string Whatsapp { get; set; }
        public required string Endeksa { get; set; }
        public List<Property> Properties { get; set; } = new List<Property>();
    }
}