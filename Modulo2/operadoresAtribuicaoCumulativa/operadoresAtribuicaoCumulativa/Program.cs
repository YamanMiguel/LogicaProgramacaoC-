using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int minutos = int.Parse(Console.ReadLine());

            double valorFranquia = 50.00;
            
            if (minutos > 100) {
                valorFranquia += (minutos - 100) * 2.0; // mais recebe (+=), é igual a valorFranquia = valorFranquia + (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar: R$" + valorFranquia.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}