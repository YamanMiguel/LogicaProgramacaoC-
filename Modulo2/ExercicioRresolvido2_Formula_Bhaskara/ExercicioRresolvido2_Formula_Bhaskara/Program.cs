using System;
using System.Globalization;

namespace FormulaBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, bhaskara, R1, R2;

            string[] ABC = Console.ReadLine().Split(' ');

            A = double.Parse(ABC[0], CultureInfo.InvariantCulture);
            B = double.Parse(ABC[1], CultureInfo.InvariantCulture);
            C = double.Parse(ABC[2], CultureInfo.InvariantCulture);

            bhaskara = Math.Pow(B, 2.0) - (4 * A * C);

            if (A == 0.0 || bhaskara < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(bhaskara)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(bhaskara)) / (2.0 * A);

                Console.WriteLine(R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine(R2.ToString("F5", CultureInfo.InvariantCulture));
            }

        }
    }
}