namespace UnitTests
{
    using Linea.Shared;
    using NUnit.Framework;

    [TestFixture]
    public class CellLocationHelperTests
    {
        [Test]
        public void GetNeighboursLocation_GetMiddleCellLocation_ReturnsEightNeighbours()
        {
            var middleCell = new CellLocation(2, 2);

            var neighboursLocations = CellLocationHelper.GetNeighboursLocations(middleCell);

            Assert.AreEqual(8, neighboursLocations.Count);
        }

        [Test]
        public void GetNeighboursLocation_GetMiddleCellLocation_ReturnsCorrectNeighbours()
        {
            var middleCell = new CellLocation(2, 2);

            var neighboursLocations = CellLocationHelper.GetNeighboursLocations(middleCell);

            Assert.Contains(new CellLocation(1, 1), neighboursLocations);
            Assert.Contains(new CellLocation(1, 2), neighboursLocations);
            Assert.Contains(new CellLocation(1, 3), neighboursLocations);
            Assert.Contains(new CellLocation(2, 1), neighboursLocations);
            Assert.Contains(new CellLocation(2, 3), neighboursLocations);
            Assert.Contains(new CellLocation(3, 1), neighboursLocations);
            Assert.Contains(new CellLocation(3, 2), neighboursLocations);
            Assert.Contains(new CellLocation(3, 3), neighboursLocations);
        }

        [Test]
        public void GetNeighboursLocation_GetTopLeftCellLocation_ReturnsEightNeighbours()
        {
            var topCell = new CellLocation(0, 0);

            var neighboursLocations = CellLocationHelper.GetNeighboursLocations(topCell);

            Assert.AreEqual(3, neighboursLocations.Count);
        }

        [Test]
        public void GetNeighboursLocation_GetTopLeftCellLocation_ReturnsCorrectNeighbours()
        {
            var topCell = new CellLocation(0, 0);

            var neighboursLocations = CellLocationHelper.GetNeighboursLocations(topCell);

            Assert.Contains(new CellLocation(0, 1), neighboursLocations);
            Assert.Contains(new CellLocation(1, 0), neighboursLocations);
            Assert.Contains(new CellLocation(1, 1), neighboursLocations);
        }

        [Test]
        public void GetNeighboursLocation_GetBottomRightCellLocation_ReturnsEightNeighbours()
        {
            var maxLengthIndex = CellLocationHelper.FieldLength - 1;
            var bottomCell = new CellLocation(maxLengthIndex, maxLengthIndex);

            var neighboursLocations = CellLocationHelper.GetNeighboursLocations(bottomCell);

            Assert.AreEqual(3, neighboursLocations.Count);
        }

        [Test]
        public void GetNeighboursLocation_GetBottomRigthCellLocation_ReturnsCorrectNeighbours()
        {
            var maxLengthIndex = CellLocationHelper.FieldLength - 1;
            var bottomCell = new CellLocation(maxLengthIndex, maxLengthIndex);

            var neighboursLocations = CellLocationHelper.GetNeighboursLocations(bottomCell);

            Assert.Contains(new CellLocation(9, 8), neighboursLocations);
            Assert.Contains(new CellLocation(8, 8), neighboursLocations);
            Assert.Contains(new CellLocation(8, 9), neighboursLocations);
        }
    }
}