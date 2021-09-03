using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan
{
    class ManhattanService
    {
        public static int manhattanDistance(Point point1, Point point2)
        {
            return point1.CompareColumn(point2) + point1.CompareRow(point2);

        }
    }
}
