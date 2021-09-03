using System;

namespace GeometriaDelTaxista
{
    class Program
    {
        static void Main(string[] args)
        {
            DistanceService service = new DistanceService();
            
            Console.WriteLine(service.Calculate(new Point(1,1), new Point(1,1)));
            Console.WriteLine(service.Calculate(new Point(5, 4), new Point(3, 2)));
            Console.WriteLine(service.Calculate(new Point(1, 1), new Point(0, 3)));


        }
    }
}
