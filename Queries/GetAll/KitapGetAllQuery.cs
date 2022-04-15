using BootcampAPIProje.DTOs;
using MediatR;

namespace BootcampAPIProje.Queries.GetAll
{
    public class KitapGetAllQuery : IRequest<ResponseDto<List<KitapDto>>>
    {
    }
}