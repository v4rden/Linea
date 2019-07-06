namespace Linea.ActorModel.Messages
{
    using Shared;

    public class PrepareToSpawnMessage
    {
        public BallColor Color { get; }

        public PrepareToSpawnMessage(BallColor color)
        {
            Color = color;
        }
    }
}