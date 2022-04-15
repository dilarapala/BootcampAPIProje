using BootcampAPIProje.DTOs;
using MediatR;

namespace BootcampAPIProje.Queries
{
    public class KitapWithPageQuery : IRequest<ResponseDto<List<KitapDto>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}