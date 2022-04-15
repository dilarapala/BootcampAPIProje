using BootcampAPIProje.DTOs;
using MediatR;

namespace BootcampAPIProje.Commands.KitapInsert
{
    public class KitapInsertCommand : IRequest<ResponseDto<int>>
    {
        public KitapDto newKitap { get; set; }
    }
}
