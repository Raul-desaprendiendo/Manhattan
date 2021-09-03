using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan {
    class MeassurementService {
        /// <summary>
        /// Calcula la suma de distancias, en el eje X y el eje Y (filas y columnas)
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static int ManhattanDistance(Point point1, Point point2) {           
            return point1.CompareColumns(point2) + point1.CompareRow(point2);
        }
    }
}
