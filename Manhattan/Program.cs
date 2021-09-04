using Manhattan.clases;
using Manhattan.servicios;
using System;
using System.Reflection;

namespace Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            MeasurementService measurementService = new MeasurementService();
            Point p1 = new Point(1,0);
            Point p2 = new Point(2,3);

            MethodInfo CompareX = p1.GetType().GetMethod("CompareX",
                BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo CompareY = p1.GetType().GetMethod("CompareY",
                BindingFlags.NonPublic | BindingFlags.Instance);

            int comparedX = (int)CompareX.Invoke(p1, new object[] { p2 });
            int comparedY = (int)CompareY.Invoke(p1, new object[] { p2 });

            Console.WriteLine($"resultado: {measurementService.Calculate(comparedX, comparedY)}");



        }
    }
}
