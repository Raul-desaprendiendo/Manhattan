using Manhattan.Interface;
using Manhattan.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.Models
{
    class Point : IMeassurement
    {
        private int _row;
        private int _column;

        public Point(int row, int column)
        {
            _row = row;
            _column = column;
        }

        public int ManhattanDistance(Point point1, Point point2)
        {
            int d1 = Math.Abs(point1._row - point2._row);
            int d2 = Math.Abs(point1._column - point2._column);
            return d1 + d2;
        }
    }
}

