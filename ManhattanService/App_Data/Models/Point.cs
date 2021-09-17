using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Manhattan
{
    public class Point
    {
        private int _column;
        private int _row;

        public Point(int column, int row)
        {
            _column = column;
            _row = row;
        }

        public int CompareColumns(Point endPoint)
        {
            return Math.Abs(_column - endPoint._column);
        }

        public int CompareRow(Point endPoint)
        {
            return Math.Abs(_row - endPoint._row);
        }
    }
}