﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaDelTaxista
{
    
    public class Point
    {
        private readonly int _row;
       
        private readonly int _column;
       
        public Point(int row, int column)
        {
            _row = row;
            _column = column;
        }

        public int GetDistanceRow(Point endPoint)
        {
            return Math.Abs(_row - endPoint._row);
        }
        public int GetDistanceColumn(Point endPoint)
        {
            return Math.Abs(_column - endPoint._column);
        }
        
       

    }
    
    
}
