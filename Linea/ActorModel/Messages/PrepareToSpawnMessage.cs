namespace Linea.ActorModel.Messages
{
    public class PrepareToSpawnMessage
    {
        public string Color { get; private set; }

        public PrepareToSpawnMessage(string color)
        {
            Color = color;
        }
    }
}