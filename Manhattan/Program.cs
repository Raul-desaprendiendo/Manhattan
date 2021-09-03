using Manhattan.Services;
using System;

namespace Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(5, 4);
            Point point2 = new Point(3, 2);

            Point point3 = new Point(1, 1);
            Point point4 = new Point(1, 1);

            Point point5 = new Point(1, 1);
            Point point6 = new Point(0, 3);


            var Distance = new MeassurementService();
           


            Console.WriteLine(Distance.ManhattanDistance(point1, point2));
            Console.WriteLine(Distance.ManhattanDistance(point3, point4));
            Console.WriteLine(Distance.ManhattanDistance(point5, point6));
        }
    }
}
