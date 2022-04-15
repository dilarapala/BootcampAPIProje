using BootcampAPIProje.DTOs;
using MediatR;

namespace BootcampAPIProje.Commands.KitapUpdate
{
    public class KitapUpdateCommand : IRequest<ResponseDto<NoContent>>
    {
        public int Isbn { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public decimal Fiyat { get; set; }
    }
}
