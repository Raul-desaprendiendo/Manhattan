using Manhattan.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.Model
{
    class IntPoint : IMeassurementPrivate
    {
        private int _row;
        private int _column;

        public IntPoint(int row, int column)
        {
            this._row = row;
            this._column = column;
        }

        public int ManhattanDistancePrivate (IntPoint point1, IntPoint point2)
        {

            int d1 = point1._row - point2._row;
            int d2 = point1._column - point2._column;

            d1 = Math.Abs(d1);
            d2 = Math.Abs(d2);

            return Math.Abs(d1) + Math.Abs(d2);
        }
    }
}
