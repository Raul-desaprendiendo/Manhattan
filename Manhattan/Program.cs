using Manhattan.Services;
using ManhattanService;
using System;

namespace Manhattan
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var man = new MeassurementService();
            Console.WriteLine(man.ManhattanDistance(man.GetPoint(2, 4), man.GetPoint(5, 9)));
        }
    }
}