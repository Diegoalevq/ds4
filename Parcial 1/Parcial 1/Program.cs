using System;


public class Program

{
      public static void Main(string[] args)
    {
        
        int n;
        do
        {
            Console.Write("Introduce el tamaño de la matriz (Solo numero impar): ");
            n = int.Parse(Console.ReadLine());
        } while (n % 2 == 0); 

       
        int[,] matriz = new int[n, n];
        Random random = new Random();

        
        for (int i = 0; i < n; i++)
        {
            matriz[i, n - 1 - i] = random.Next(101, 201); 
        }

       
        Console.WriteLine("Matriz generada:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

       
        int sumaDiagonalPrincipal = 0;
        for (int i = 0; i < n; i++)
        {
            sumaDiagonalPrincipal += matriz[i, i];
        }

       
        int sumaDiagonalInversa = 0;
        for (int i = 0; i < n; i++)
        {
            sumaDiagonalInversa += matriz[i, n - 1 - i];
        }

       
        Console.WriteLine($"Suma de la diagonal principal: {sumaDiagonalPrincipal}");
        Console.WriteLine($"Suma de la diagonal inversa: {sumaDiagonalInversa}");
    }
}
