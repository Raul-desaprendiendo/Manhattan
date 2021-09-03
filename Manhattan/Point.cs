using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan {
	public class Point {
		private int _column;
		private int _row;
		public Point(int columna, int row) {
			_column = columna;
			_row = row;
		}
		/// <summary>
		/// Compara las columnas de 2 puntos
		/// </summary>
		/// <param name="endPoint"></param>
		/// <returns></returns>
		public int CompareColumns(Point endPoint) {
			return Math.Abs(_column - endPoint._column);
		}
		/// <summary>
		/// Compara las filas de 2 puntos
		/// </summary>
		/// <param name="endPoint"></param>
		/// <returns></returns>
		public int CompareRow(Point endPoint) {
			return Math.Abs(_row - endPoint._row);
		}
	}
}
