using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Manhattan
{
    internal class Point
    {
        private int _x;
        private int _y;

        public Point(int columna, int row)
        {
            _x = columna;
            _y = row;
        }

        private int GetX()
        {
            return _x;
        }

        private int GetY()
        {
            return _y;
        }
    }
}