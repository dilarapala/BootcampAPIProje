using BootcampAPIProje.DTOs;
using BootcampAPIProje.Repositories;
using MediatR;

namespace BootcampAPIProje.Commands.KitapDelete
{
    public class KitapDeleteCommandHandler : IRequestHandler<KitapDeleteCommand, ResponseDto<NoContent>>
    {
        private readonly IKitapRepository _kitapRepository;

        public KitapDeleteCommandHandler(IKitapRepository kitapRepository)
        {
            _kitapRepository = kitapRepository;
        }

        public async Task<ResponseDto<NoContent>> Handle(KitapDeleteCommand request, CancellationToken cancellationToken)
        {

            var result = await _kitapRepository.Delete(request);

            if (!result)
            {
                return ResponseDto<NoContent>.Fail("silme işlemi başarısız", 500);
            }

            return ResponseDto<NoContent>.Success(204);

        }
    }
}
