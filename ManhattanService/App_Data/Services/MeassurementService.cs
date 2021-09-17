using Manhattan.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Manhattan.Services
{
    public class MeassurementService : IDistanceMeassurement
    {
        public Point GetPoint(int x, int y)
        {
            return new Point(x, y);
        }

        public int ManhattanDistance(Point point1, Point point2)
        {
            return point1.CompareColumns(point2) + point1.CompareRow(point2);
        }
    }
}