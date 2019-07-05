namespace UnitTests
{
    using Akka.Actor;
    using Akka.TestKit.NUnit3;
    using Linea.ActorModel.Actors;
    using Linea.ActorModel.Messges;
    using Linea.Shared;
    using NUnit.Framework;

    [TestFixture]
    public class CellActorTests : TestKit
    {
        [Test]
        public void Clear_GotClearMessage_StateSetToEmpty()
        {
            var prop = Props.Create(() => new CellActor(1, 1));
            var cellActor = ActorOfAsTestActorRef<CellActor>(prop);

            cellActor.Tell(new ClearMessage());

            Assert.AreEqual(CellState.Empty, cellActor.UnderlyingActor.State);
        }
    }
}