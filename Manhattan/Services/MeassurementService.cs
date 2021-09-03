using Manhattan.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Manhattan.Services
{
    class MeassurementService : IDistanceMeassurement
    {
        public int ManhattanDistance(Point point1, Point point2)
        {

            MethodInfo getX = point1.GetType().GetMethod("GetX", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo getY = point1.GetType().GetMethod("GetY", BindingFlags.NonPublic | BindingFlags.Instance);

            int P1x = (int) getX.Invoke(point1, new object[] { });
            int P1y = (int) getY.Invoke(point1, new object[] { });
            int P2x = (int) getX.Invoke(point2, new object[] { });
            int P2y = (int) getY.Invoke(point2, new object[] { });

            return Math.Abs(P1x - P2x) + Math.Abs(P1y - P2y);

           
        }

        
    }
}
