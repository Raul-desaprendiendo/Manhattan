using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manhattan.library
{
    public interface IMeassurementService
    {
        Point GetPoint(int x, int y);

        int ManhattanDistanceByCoords(int p1x, int p1y, int p2x, int p2y);
    }
}