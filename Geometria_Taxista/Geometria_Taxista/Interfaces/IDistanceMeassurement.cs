
using Geometria_Taxista.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria_Taxista.Interfaces
{
    public interface IDistanceMeassurement
    {
        /// <summary>
        /// action of calculate.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public int CalculateDistance(Point p1, Point p2);
    }
}
