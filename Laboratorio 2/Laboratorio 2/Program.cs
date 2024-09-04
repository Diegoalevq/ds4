using System;
namespace Laboratorio2
{
    class Program
    {

        //Definición de método que suma dos números e imprime el resultado.
        public void Sumar(int valor1, int valor2)
        {
            int variableLocal = valor1 + valor2; //Declarando la variable local
            Console.WriteLine(variableLocal); //Esto imprime el resultado de la suma.
        }
        Console.WriteLine(variableLocal); //Esto presenta un error de compilación

    private static void Main(string[] args)
        {
            Client cliente = new Client();
            //Ejemplo utilizando las variables de instancia de clase
            cliente.FirstName = "Diego";
            cliente.LastName = "Viña";
            cliente.Age = 15;
            cliente.Id = 1;

            Console.WriteLine(cliente.GetFullName());

            //asignando valor a la variable estatica
            Program.Valor = 1;
            Console.WriteLine(Program.Valor);
            //Declaración de variables
            int nombreVariable = 1000;
            int valor1 = 28;
            int valor2 = valor1; //asignamos el valor de valor1 a valor2
            valor2 = 30;
            //Imprimiendo en consolas variables
            Console.WriteLine(valor1);
            Console.WriteLine(valor2)

        }

        public class Client
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public ushort Age { get; set; }

            public string GetFullName()
            {
                //Utilizando variables de instancia dentro de metodos de la clase.
                return FirstName + " " + LastName;
            }
        }

        public class MyClass
        {
            //Declarando variables estaticas
            public static int Valor;

            //Variables tipo referencia
            MyClass object1 = new MyClass(); //creando una nueva instancia
            object1.Nombre = "Pedro";
            object1.Edad = 28;
            MyClass object2 = object1; //asignando variable a otra
            //este cambio en la propiedad afecta tanto a object1 como a object2
            object.Nombre = "Larry";
            //Al imprimir en consola vemos que ambas referencias imprimem el mismo valor Jose.
            Console.WriteLine(object2.Nombre);
            Console.WriteLine(object1.Nombre);

            char caracter = "A";
            string cadena = "Cadena de carácteres";
            bool condicion = true;

        }

    }
