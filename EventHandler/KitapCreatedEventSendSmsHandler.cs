using BootcampAPIProje.Events;
using MediatR;

namespace BootcampAPIProje.EventHandler
{
    public class KitapCreatedEventSendSmsHandler : INotificationHandler<KitapCreatedEvent>
    {
        private readonly ILogger<KitapCreatedEventSendSmsHandler> _logger;

        public KitapCreatedEventSendSmsHandler(ILogger<KitapCreatedEventSendSmsHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(KitapCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Sms Gönderildi : Kitap isbn={notification.KitapIsbn} Kitap ismi : {notification.KitapAdi}");

            return Task.CompletedTask;
        }
    }
}