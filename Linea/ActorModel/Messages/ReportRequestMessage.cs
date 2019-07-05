namespace Linea.ActorModel.Messges
{
    public class ReportRequestMessage
    {
        public string Sender { get; private set; }

        public ReportRequestMessage(string sender)
        {
            Sender = sender;
        }
    }
}