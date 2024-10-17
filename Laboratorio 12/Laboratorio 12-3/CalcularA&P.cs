using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_12_3
{
    internal class CalcularA_P
    {
        public double CalcularSemiper(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA + ladoB + ladoC) / 2;
        }
        public double CalcularArea(double ladoA, double ladoB, double ladoC)
        {
            double semiperimetro = CalcularSemiper(ladoA, ladoB, ladoC);
            return Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro- ladoC));
                            
        }
        }

}
