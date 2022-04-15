using BootcampAPIProje.DTOs;
using BootcampAPIProje.Repositories;
using MediatR;

namespace BootcampAPIProje.Commands.KitapInsert
{
    public class KitapInsertCommandHandler : IRequestHandler<KitapInsertCommand, ResponseDto<int>>
    {
        private readonly IKitapRepository _kitapRepository;
        private readonly IMediator mediator;

        public KitapInsertCommandHandler(IKitapRepository kitapRepository, IMediator mediator)
        {
            _kitapRepository = kitapRepository;
            this.mediator = mediator;
        }

        public async Task<ResponseDto<int>> Handle(KitapInsertCommand request, CancellationToken cancellationToken)
        {
            var isbn = await _kitapRepository.Save(request);

            return ResponseDto<int>.Success(isbn, 201);
        }
    }
}

