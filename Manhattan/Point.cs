using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan
{
    class Point
    {
        private int _row;
        private int _column;

        public Point(int row, int column)
        {
            _row = row;
            _column = column;
        }
        public int CompareColumn(Point endPoint)
        {
            return Math.Abs(_column - endPoint._column);
        }
        public int CompareRow(Point endPoint)
        {
            return Math.Abs(_row - endPoint._row);
        }
    }
}
