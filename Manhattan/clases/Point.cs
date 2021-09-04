using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.clases
{
    class Point
    {
        private int CoordX;
        private int CoordY;
        private Random random = new Random();
        
        public Point(int CoordX, int CoordY)
        {
            this.CoordX = CoordX;
            this.CoordY = CoordY;
        }

        /// <summary>
        /// Compara el valor de la coordenada X de Point con el de otro objeto Point
        /// </summary>
        /// <param name="point">Objeto point con el que se compara la coordenada X</param>
        /// <returns>Resultado absoluto de la comparación</returns>
        private int CompareX(Point point)
        {
            return Math.Abs(this.CoordX - point.CoordX);
        }

        /// <summary>
        /// Compara el valor de la coordenada Y de Point con el de otro objeto Point
        /// </summary>
        /// <param name="point">Objeto point con el que  se compara la coordenada Y</param>
        /// <returns>Resultado absoluto de la comparación</returns>
        private int CompareY(Point point)
        {
            return Math.Abs(this.CoordY - point.CoordY);
        }
    }
}
