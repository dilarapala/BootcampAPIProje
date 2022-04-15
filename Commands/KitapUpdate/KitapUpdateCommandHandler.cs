using BootcampAPIProje.DTOs;
using BootcampAPIProje.Repositories;
using MediatR;

namespace BootcampAPIProje.Commands.KitapUpdate
{
    public class KitapUpdateCommandHandler : IRequestHandler<KitapUpdateCommand, ResponseDto<NoContent>>
    {
        private readonly IKitapRepository _repository;

        public KitapUpdateCommandHandler(IKitapRepository repository)
        {
            _repository = repository;
        }


        public async Task<ResponseDto<NoContent>> Handle(KitapUpdateCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.Update(request);

            if (!result)
            {
                return ResponseDto<NoContent>.Fail("update işlemi başarısız", 500);
            }

            return ResponseDto<NoContent>.Success(204);
        }
    }
}
