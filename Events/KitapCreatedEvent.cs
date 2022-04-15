using MediatR;
namespace BootcampAPIProje.Events
{
    public class KitapCreatedEvent : INotification
    {
        public int KitapIsbn { get; set; }
        public string KitapAdi { get; set; }
    }
}
