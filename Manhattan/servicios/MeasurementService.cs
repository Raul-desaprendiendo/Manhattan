using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.servicios
{
    class MeasurementService
    {
        /// <summary>
        /// Con valores de coordenadas ya comparadas, calcula la distancia de un punto a otro
        /// </summary>
        /// <param name="comparedX">Coordenada X ya comparada entre dos puntos</param>
        /// <param name="comparedY">Coordenada Y ya comparada entre dos puntos</param>
        /// <returns>Valor de la distancia entre ambos puntos</returns>
        public int Calculate(int comparedX, int comparedY)
        {
            return Math.Abs(comparedX + comparedY);
        }


    }
}
