using Geometria_Taxista.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria_Taxista.Models
{
    /// <summary>
    /// extends of the interface to get the points.
    /// </summary>
    public class DistanceService : IDistanceMeassurement
    {
        /// <summary>
        /// Here I calculate the point.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>we get p1 of row p2, and the same one with columns</returns>
        public int CalculateDistance(Point p1, Point p2)
        {
            return p1.GetRow(p2) + p1.GetColumn(p2);
        }
    }
}
