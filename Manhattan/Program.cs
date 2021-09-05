using Manhattan.Model;
using Manhattan.Models;
using Manhattan.Service;
using Manhattan.Interface;
using System;
using System.Collections;
using System.Reflection;

namespace Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(1, 1);
            Point point3 = new Point(5, 4);
            Point point4 = new Point(3, 2);
            Point point5 = new Point(1, 1);
            Point point6 = new Point(0, 3);

            MeassurementService meassurementService = new MeassurementService();

            meassurementService.ManhattanDistance(point1, point2);
            meassurementService.ManhattanDistance(point3, point4);
            meassurementService.ManhattanDistance(point5, point6);

            IntPoint point55 = new IntPoint(1, 1);
            IntPoint point66 = new IntPoint(0, 3);

            MethodInfo privMethod = point55.GetType().GetMethod("ManhattanDistancePrivate", BindingFlags.NonPublic | BindingFlags.Instance);
            
            privMethod.Invoke(point55, new object[] { point55, point66 });


            meassurementService.ManhattanDistancePrivate(point55, point66, privMethod);

        }

        
        
    }
}
