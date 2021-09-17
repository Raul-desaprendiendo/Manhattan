using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Manhattan.Interfaces
{
    internal interface IDistanceMeassurement
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Distance")]
        int ManhattanDistance(Point point1, Point point2);

        [OperationContract]
        Point GetPoint(int x, int y);
    }
}