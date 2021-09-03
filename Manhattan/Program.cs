using System;

namespace Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1,1);
            Point point2 = new Point(1,10);
            Point point3 = new Point(50,27);

            Console.WriteLine("La distancia entre el punto1 y el punto2 es: " + MeassurementService.ManhattanDistance(point1, point2));
            Console.WriteLine("La distancia entre el punto2 y el punto3 es: " + MeassurementService.ManhattanDistance(point2, point3));
            Console.WriteLine("La distancia entre el punto1 y el punto3 es: " + MeassurementService.ManhattanDistance(point1, point3));
        }
    }
}
