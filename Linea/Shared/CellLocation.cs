namespace Linea.Shared
{
    using System;
    using Ninject;

    public class CellLocation
    {
        public int Column { get; }
        public int Row { get; }

        public CellLocation(int column, int row)
        {
            if(column < 0)
                throw new ArgumentException("Column value can't be less than zero");
            
            if(row< 0)
                throw new ActivationException("Row value can't be less than zero");
            
            if (column > CellLocationHelper.FieldLength)
                throw new ArgumentException(
                    $"Column {column} is greater than possible value of {CellLocationHelper.FieldLength}");

            if (row > CellLocationHelper.FieldLength)
                throw new ArgumentException(
                    $"Row {row} is greater than possible value of {CellLocationHelper.FieldLength}");

            Column = column;
            Row = row;
        }


        public override bool Equals(Object obj)
        {
            CellLocation cl = obj as CellLocation;
            if (cl == null)
                return false;

            return Row == cl.Row && Column == cl.Column;
        }

        public bool Equals(CellLocation cl)
        {
            if (cl == null)
                return false;

            return Row == cl.Row && Column == cl.Column;
        }

        public override int GetHashCode()
        {
            return Row ^ Column;
        }
    }
}