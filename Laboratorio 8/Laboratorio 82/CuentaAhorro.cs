
namespace Laboratorio_82
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmtIdCuenta) : base(prmtdIdCuenta)
        {

        }
        public override void CalcularIntereses()
        {
            System.Console.WriteLine("CuentaAhorro.CalcularIntereses() efectuado para " + "la cuenta {0}", getIdCuenta());
        }
    }
}
