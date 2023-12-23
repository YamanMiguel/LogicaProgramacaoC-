using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {


            double idade = double.Parse(Console.ReadLine());

            double soma = 0.0;

            int cont = 0;

            double resultado = 0.0;

            if (idade < 0)
            {

            }

            while (idade >= 0)
            {
                soma += idade;
                idade = double.Parse(Console.ReadLine());
                cont++;
            }

            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                resultado = soma / cont;
                Console.WriteLine(resultado);
            }


        }
    }
}