using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class ClsExponent
    {
        public double Exponent(double N1, double N2)
        {
            double S;
            S = Math.Pow(N1, N2);
            return S;
        }
    }
}
