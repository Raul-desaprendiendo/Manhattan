using Manhattan.Model;
using Manhattan.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Manhattan.Service
{
    class MeassurementService
    {
        public void ManhattanDistance(Point point1, Point point2)
        {
            Console.WriteLine($"Manhattan Distance ptos : { point1.ManhattanDistance(point1, point2)}");
        }
        public void ManhattanDistancePrivate(IntPoint point1, IntPoint point2, MethodInfo Method)
        {
            Console.WriteLine($"Manhattan Distance ptos : {point1.CalcColumn(point2) + point1.CalcRow(point2)}");
        }

    }
}

