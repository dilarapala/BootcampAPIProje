using BootcampAPIProje.Models;

namespace BootcampAPIProje.DTOs
{
    public class KitapDto
    {
        public int Isbn { get; set; }

        public string KitapAdi { get; set; }

        public string YazarAdi { get; set; }

        public decimal Fiyat { get; set; }

        public KitapDto()
        {

        }

        public KitapDto(Kitap kitap) => (Isbn, KitapAdi, YazarAdi, Fiyat) = (kitap.Isbn, kitap.KitapAdi, kitap.YazarAdi, kitap.Fiyat);

    }
}
