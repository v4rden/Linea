namespace UnitTests
{
    using Akka.Actor;
    using Akka.TestKit;
    using Akka.TestKit.NUnit3;
    using Linea.ActorModel.Actors;
    using Linea.ActorModel.Messages;
    using Linea.ActorModel.Messges;
    using Linea.Shared;
    using NUnit.Framework;

    [TestFixture]
    public class CellActorTests : TestKit
    {
        [Test]
        public void Clear_GotClearMessage_StateSetToEmpty()
        {
            var cellActor = GetCellTestActorRef();

            cellActor.Tell(new ClearMessage());

            Assert.AreEqual(CellState.Empty, cellActor.UnderlyingActor.State);
        }

        [Test]
        public void PrepareToSpawn_GotPrepareToSpawnMessage_StateSetToSpawning()
        {
            var cellActor = GetCellTestActorRef();

            cellActor.Tell(new PrepareToSpawnMessage(BallColor.Blue));

            Assert.AreEqual(CellState.Spawning, cellActor.UnderlyingActor.State);
        }
        
        [Test]
        public void PrepareToSpawn_GotPrepareToSpawnMessage_ColorSetToSentInMessage()
        {
            var cellActor = GetCellTestActorRef();

            cellActor.Tell(new PrepareToSpawnMessage(BallColor.Blue));

            Assert.AreEqual(BallColor.Blue, cellActor.UnderlyingActor.Color);
        }
        
        [Test]
        public void Update_GotTurnPassedMessage_StateSetToOccupied()
        {
            var cellActor = GetCellTestActorRef();

            cellActor.Tell(new TurnHavePassedMessage());

            Assert.AreEqual(CellState.Occupied, cellActor.UnderlyingActor.State);
        }

        private TestActorRef<CellActor> GetCellTestActorRef()
        {
            var prop = Props.Create(() => new CellActor(new CellLocation(1,1)));
            var cellActor = ActorOfAsTestActorRef<CellActor>(prop);
            return cellActor;
        }
    }
}