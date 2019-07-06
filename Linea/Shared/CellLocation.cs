namespace Linea.Shared
{
    using System;

    public class CellLocation
    {
        public int Column { get; private set; }
        public int Row { get; private set; }

        public CellLocation(int column, int row)
        {
            if (column > CellLocationHelper.FieldLength)
            {
                throw new ArgumentException(
                    $"Columnt {column} is greater than possible value of {CellLocationHelper.FieldLength}");
            }
            
            if (row > CellLocationHelper.FieldLength)
            {
                throw new ArgumentException(
                    $"Row {row} is greater than possible value of {CellLocationHelper.FieldLength}");
            }

            Column = column;
            Row = row;
        }
    }
}