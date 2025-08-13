namespace PentaNest.Emlak.Api.Models
{
    public class Property
    {
        public required string Id { get; set; }
        public required string ImageURL { get; set; }
        public required string Title { get; set; }
        public required int Price { get; set; }
        public required string Location { get; set; }
        public required string Emlakci { get; set; }
        public required string Durum { get; set; }
        public required string KonumLinki { get; set; }
        public required string Aciklama { get; set; }
        public required int M2 { get; set; }
        public string? OdaSayisi { get; set; }
        public required string IlanTarihi { get; set; }
        public required string EmlakTipi { get; set; }
        public int? BinaYasi { get; set; }
        public string? BulunduguKat { get; set; }
        public int? KatSayisi { get; set; }
        public string? Isitma { get; set; }
        public string? BanyoSayisi { get; set; }
        public string? MutfakTipi { get; set; }
        public string? Balkon { get; set; }
        public string? Asansor { get; set; }
        public string? Otopark { get; set; }
        public string? Esyali { get; set; }
        public string? KullanimDurumu { get; set; }
        public string? SiteIcerisinde { get; set; }
        public string? KrediyeUygun { get; set; }
        public string? TapuDurumu { get; set; }
        public string? Kimden { get; set; }
        public string? Takas { get; set; }
        public string? HaritaUrl { get; set; }
        public required int ImageCount { get; set; }
    }
}