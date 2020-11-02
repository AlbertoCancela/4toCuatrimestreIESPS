using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class ClsPercentage
    {
        public double Percentage(double N1, double N2)
        {
            double Prc;
            Prc = (N1 * N2)/100;
            return Prc;
        }

    }
}
