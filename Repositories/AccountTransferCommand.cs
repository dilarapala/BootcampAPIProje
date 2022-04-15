namespace BootcampAPIProje.Repositories
{
    public class AccountTransferCommand
    {
        public object Sender { get; internal set; }
        public object Receiver { get; internal set; }
        public object Amount { get; internal set; }
    }
}