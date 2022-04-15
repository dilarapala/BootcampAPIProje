namespace BootcampAPIProje.DTOs
{
    public class KitapRequestDto
    {
        public int Isbn { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public decimal? Fiyat { get; set; }
    }
}