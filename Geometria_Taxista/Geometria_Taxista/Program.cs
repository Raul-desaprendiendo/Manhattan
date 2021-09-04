using Geometria_Taxista.Models;
using System;

namespace Geometria_Taxista
{
    class Program
    {
        static void Main(string[] args)
        {
            // I create the new parameter "d", to pass all the info.
            DistanceService d = new DistanceService();
            
            // each point is throw to new points, and with the method of calculate create the result.
            Console.WriteLine(d.CalculateDistance(new Point(1, 1), new Point(1, 1)));
            Console.WriteLine(d.CalculateDistance(new Point(5, 4), new Point(3, 2)));
            Console.WriteLine(d.CalculateDistance(new Point(1, 1), new Point(0, 3)));

        }
    }
}
