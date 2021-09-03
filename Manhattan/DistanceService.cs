using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaDelTaxista
{
    
    public class DistanceService : IDistanceMeasurement
    {
        public int Calculate(Point p1 , Point p2)
        {
          
            return p1.GetDistanceRow(p2) + p1.GetDistanceColumn(p2);
        }
        
    }
}
