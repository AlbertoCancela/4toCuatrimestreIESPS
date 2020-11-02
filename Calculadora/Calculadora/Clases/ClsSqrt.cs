using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class ClsSqrt
    {   public double Sqrt(double N1, double N2)
        {
            double Sqrt;
            N1 = 1 / N1;
            Sqrt = Math.Pow(N2, N1);
            return Sqrt;
        }
    }
}
