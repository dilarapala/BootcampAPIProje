using BootcampAPIProje.DTOs;
using MediatR;

namespace BootcampAPIProje.Commands.KitapDelete
{
    public class KitapDeleteCommand : IRequest<ResponseDto<NoContent>>
    {
        public int Isbn { get; set; }
    }
}