
    internal class Laboratorio31
    {
        public class CalculosMatematicos
        {
            public static int Calcular(int a, int b)
            {
                return (a + b) * (a - b);
            }
        }


        private static void Main(string[] args)
        {
            Console.Write("Inroduzca el primer numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultado = CalculosMatematicos.Calcular(a, b);
            Console.WriteLine("El resultado de la operacion (a + b) * (a - b) es: {0}", resultado);
        }

    }
