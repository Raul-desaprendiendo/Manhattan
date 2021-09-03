using System;
using System.Collections;

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

            Console.WriteLine("Manhattan Distance ptos (1, 1) y (1, 1) " + ManhattanService.manhattanDistance(point1,point2));
            Console.WriteLine("Manhattan Distance ptos (5, 4) y (3, 2) " + ManhattanService.manhattanDistance(point3, point4));
            Console.WriteLine("Manhattan Distance ptos (1,1) y (0,3) " + ManhattanService.manhattanDistance(point5, point6));
        }

        
        
    }
}
