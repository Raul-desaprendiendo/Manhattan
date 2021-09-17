using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.Servicios
{
    public class MensurationService
    {
        public int Calculate(int x, int y)
        {
            return Math.Abs(x + y);
        }
    }
}
