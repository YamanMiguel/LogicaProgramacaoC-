using System;
using System.Globalization;

namespace curso
{
    class Program { 
    
        static void Main(string[] args)
        {
            double a, b, area, perimetro, diagonal;
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = a * b;
            perimetro = a * 2 + b * 2;
            diagonal = Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0));



            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " +  perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " +  diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    
    }
} 
