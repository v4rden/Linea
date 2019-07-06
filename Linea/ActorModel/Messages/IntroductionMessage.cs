namespace Linea.ActorModel.Messages
{
    using Akka.Actor;

    public class IntroductionMessage
    {
        public IActorRef ItIsMe { get; }

        public IntroductionMessage(IActorRef sender)
        {
            ItIsMe = sender;
        }
    }
}