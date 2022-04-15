using AutoMapper;
using BootcampAPIProje.DTOs;
using BootcampAPIProje.Repositories;
using MediatR;

namespace BootcampAPIProje.Queries
{
    public class KitapWithPageQueryHandler : IRequestHandler<KitapWithPageQuery, ResponseDto<List<KitapDto>>>
    {
        private readonly IKitapRepository _kitapRepository;
        private readonly IMapper _mapper;

        public KitapWithPageQueryHandler(IKitapRepository kitapRepository, IMapper mapper)
        {
            _kitapRepository = kitapRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<KitapDto>>> Handle(KitapWithPageQuery request, CancellationToken cancellationToken)
        {
            var kitaplar = await _kitapRepository.GetAllWithPageParameters(request.Page, request.PageSize);



            return ResponseDto<List<KitapDto>>.Success(_mapper.Map<List<KitapDto>>(kitaplar), 200);

        }
    }
}