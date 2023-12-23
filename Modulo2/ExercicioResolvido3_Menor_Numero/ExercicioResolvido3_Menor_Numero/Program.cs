using System;
using System.Globalization;

namespace menorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');

            int numero1, numero2, numero3;

            numero1 = int.Parse(numeros[0]);
            numero2 = int.Parse(numeros[1]);
            numero3 = int.Parse(numeros[2]);

            if (numero1 < numero2 && numero1 < numero3)
            {
                Console.WriteLine("MENOR = " + numero1);
            }
            else if (numero2 < numero3)
            {
                Console.WriteLine("MENOR = " + numero2);
            }
            else
            {
                Console.WriteLine("MENOR = " + numero3);
            }

        }
    }
}
