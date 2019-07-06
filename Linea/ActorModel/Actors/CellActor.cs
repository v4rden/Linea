namespace Linea.ActorModel.Actors
{
    using Akka.Actor;
    using Messages;
    using Messges;
    using Shared;

    public class CellActor : ReceiveActor
    {
        public int Column { get; }
        public int Row { get; }
        public CellState State { get; private set; }
        public BallColor Color { get; private set; }

        public CellActor(int column, int row)
        {
            Column = column;
            Row = row;
            
            Receive<ClearMessage>(Clear);
            Receive<PrepareToSpawnMessage>(PrepareToSpawn);
            Receive<TurnHavePassedMessage>(Update);
        }

        private void Clear(ClearMessage message)
        {
            State = CellState.Empty;
        }

        private void PrepareToSpawn(PrepareToSpawnMessage message)
        {
            State = CellState.Spawning;
            Color = message.Color;
        }

        private void Update(TurnHavePassedMessage message)
        {
            if (State == CellState.Spawning)
            {
                State = CellState.Occupied;
            }   
        }
    }
}