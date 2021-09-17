using Manhattan;
using System;
using System.Reflection;
using Manhattan.Servicios;

namespace Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            MensurationService mensuration = new MensurationService();
            Point pointA = new Point(1, 0);
            Point pointB = new Point(2, 3);
            MethodInfo X = pointA.GetType().GetMethod("X",
            BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo Y = pointB.GetType().GetMethod("Y",
            BindingFlags.NonPublic | BindingFlags.Instance);

            int XToCompare = (int)X.Invoke(pointA, new object[] { });
            int YToCompare = (int)Y.Invoke(pointA, new object[] { });
            Console.WriteLine(@$"El resultado es: 
            {mensuration.Calculate(XToCompare, YToCompare)}");
        }
    }
}
