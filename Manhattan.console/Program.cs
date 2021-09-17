using Manhattan.console.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manhattan.console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var service = new ServiceClient();
            Console.WriteLine(service.CalculateSubtraction(8, 9));
            Console.WriteLine(service.CalculateManhattanDistanceByCoords(5, 4, 3, 2));
        }
    }
}