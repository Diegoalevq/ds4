using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    internal class Conversiones
    {
        public int BinarioADecimal(string PasvBinario)
        {
            return Convert.ToInt32(PasvBinario, 2);
        }
        
        public string DecimalABinario(int PasvDecimalBi)
        {
            return Convert.ToString(PasvDecimalBi, 2);
        }

        public int OctalADecimal(string PasvOctal)
        {
            return Convert.ToInt32(PasvOctal, 8);
        }

        public string DecimalAOctal(int PasvDecimalOct)
        {
            return Convert.ToString (PasvDecimalOct, 8);
        }
    }
}
