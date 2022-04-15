using BootcampAPIProje.Events;
using MediatR;

namespace BootcampAPIProje.EventHandler
{
    public class KitapCreatedEventSendEmailHandler : INotificationHandler<KitapCreatedEvent>
    {

        private readonly ILogger<KitapCreatedEventSendEmailHandler> _logger;

        public KitapCreatedEventSendEmailHandler(ILogger<KitapCreatedEventSendEmailHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(KitapCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Email Gönderildi : Kitap ISBN={notification.KitapIsbn} Kitap adi: {notification.KitapAdi}");

            return Task.CompletedTask;
        }
    }
}