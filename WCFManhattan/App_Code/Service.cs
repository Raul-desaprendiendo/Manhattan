using Manhattan.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    public int CalculateManhattanDistanceByCoords(int p1x, int p1y, int p2x, int p2y)
    {
        var meassurementService = new MeassurementService();
        return meassurementService.ManhattanDistanceByCoords(p1x, p1y, p2x, p2y);
    }

    public int CalculateSubtraction(int value1, int value2)
    {
        return value1 - value2;
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        if (composite == null)
        {
            throw new ArgumentNullException("composite");
        }
        if (composite.BoolValue)
        {
            composite.StringValue += "Suffix";
        }
        return composite;
    }
}