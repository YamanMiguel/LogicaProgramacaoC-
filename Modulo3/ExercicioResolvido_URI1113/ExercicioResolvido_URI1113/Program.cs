using System;
using System.Globalization;

namespace URI1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] numeros = Console.ReadLine().Split(' ');

            X = int.Parse(numeros[0]);
            Y = int.Parse(numeros[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    
                    Console.WriteLine("Decrescente");
                }
                numeros = Console.ReadLine().Split(' ');
                X = int.Parse(numeros[0]);
                Y = int.Parse(numeros[1]);
            }
        }
    }
}