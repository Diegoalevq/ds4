
namespace Laboratorio_82
{
     class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
        { 
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine("CuentaCorriente.CalculaIntereses() efectuado para " + "la cuenta {0}", getIdCuenta());
        }
    }
}
