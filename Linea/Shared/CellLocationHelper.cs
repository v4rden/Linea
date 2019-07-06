namespace Linea.Shared
{
    using System.Collections.Generic;

    public static class CellLocationHelper
    {
        public const int FieldLength = 10;

        public static List<CellLocation> GetNeighboursLocations(CellLocation location)
        {
            var neighbours = new List<CellLocation>();

            for (var i = -1; i < 2; i++)
            {
                for (var j = -1; j < 2; j++)
                {
                    var supposedColumn = location.Column + i;
                    var supposedRow = location.Row + j;
                    
                    var cl = TryGetNeighbourLocation(supposedColumn, supposedRow, location);
                    
                    if (cl != null)
                        neighbours.Add(cl);
                }
            }

            return neighbours;
        }

        private static CellLocation TryGetNeighbourLocation(int supposedColumn, int supposedRow,
            CellLocation callerLocation)
        {
            if (!AreNotNegative(supposedColumn, supposedRow) || !AreWithinRange(supposedColumn, supposedRow))
                return null;
            
            var supposedLocation = new CellLocation(supposedColumn, supposedRow);
            return IsDifferentFromCaller(supposedLocation, callerLocation)
                ? supposedLocation
                : null;
        }

        private static bool AreNotNegative(int x, int y)
        {
            return x >= 0 && y >= 0;
        }

        private static bool AreWithinRange(int x, int y)
        {
            return x < FieldLength && y < FieldLength;
        }

        private static bool IsDifferentFromCaller(CellLocation x, CellLocation y)
        {
            return !x.Equals(y);
        }
    }
}