using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manhattan.library
{
    public class MeassurementService : IMeassurementService
    {
        public Point GetPoint(int x, int y)
        {
            return new Point(x, y);
        }

        public int ManhattanDistanceByCoords(int p1x, int p1y, int p2x, int p2y)
        {
            Point point1 = GetPoint(p1x, p1y);
            Point point2 = GetPoint(p2x, p2y);
            return point1.CompareColumns(point2) + point1.CompareRow(point2);
        }
    }
}