using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do terreno:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno:");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do metro quadrado:");
            double valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = valorMetro * area;
            Console.WriteLine("A area do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O preço do terreno é: " + preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}