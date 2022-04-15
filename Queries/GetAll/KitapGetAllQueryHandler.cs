using BootcampAPIProje.DTOs;
using BootcampAPIProje.Repositories;
using MediatR;

namespace BootcampAPIProje.Queries.GetAll
{
    public class KitapGetAllQueryHandler : IRequestHandler<KitapGetAllQuery, ResponseDto<List<KitapDto>>>
    {
        private readonly IKitapRepository _kitapRepository;

        public KitapGetAllQueryHandler(IKitapRepository kitapRepository)
        {
            _kitapRepository = kitapRepository;
        }

        public async Task<ResponseDto<List<KitapDto>>> Handle(KitapGetAllQuery request, CancellationToken cancellationToken)
        {


            var products = await _kitapRepository.GetAll();

            var kitapDtos = new List<KitapDto>();

            products.ForEach(x => kitapDtos.Add(new KitapDto(x)));

            return ResponseDto<List<KitapDto>>.Success(kitapDtos, 200);
        }
    }
}