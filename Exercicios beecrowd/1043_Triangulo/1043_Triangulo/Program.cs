using System;

class URI
{

    static void Main(string[] args)
    {

        double a, b, c, perimetro, area;

        String[] vet = Console.ReadLine().Split(' ');

        a = double.Parse(vet[0]);
        b = double.Parse(vet[1]);
        c = double.Parse(vet[2]);

        if (a < b + c && b < a + c && c < a + b)
        {
            perimetro = a + b + c;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
        }
        else
        {
            area = ((a + b) * c) / 2;
            Console.WriteLine("Area = " + area.ToString("F1"));
        }

    }

}
