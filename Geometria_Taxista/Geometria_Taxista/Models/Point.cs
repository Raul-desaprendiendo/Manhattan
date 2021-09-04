
using Geometria_Taxista.Interfaces;
using System;
using System.Text;

namespace Geometria_Taxista.Models
{

    public class Point
    {

        private int _column;
        private int _row;
        /// <summary>
        /// initialize param that I am going to need to get the result.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row"></param>
        public Point(int column, int row)
        {
            _column = column;
            _row = row;

        }
        /// <summary>
        /// it compares both columns and get the correct number.
        /// </summary>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public int GetColumn(Point endPoint)
        {
            return Math.Abs(_column - endPoint._column);
        }
        /// <summary>
        /// it compares both rows, and get the correct number.
        /// </summary>
        /// <param name="endPoint"></param>
        /// <returns> I use Math.Abs to return the absolute valor of the parameteres.</returns>
        public int GetRow(Point endPoint)
        {
            return Math.Abs(_row - endPoint._row);
        }
        
    }
}
