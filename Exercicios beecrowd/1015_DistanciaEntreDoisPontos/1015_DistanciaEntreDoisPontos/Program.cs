using System;

class URI
{

    static void Main(string[] args)
    {

        string[] x = Console.ReadLine().Split(' ');
        string[] y = Console.ReadLine().Split(' ');

        double x1, x2, y1, y2, distancia;

        x1 = double.Parse(x[0]);
        y1 = double.Parse(x[1]);

        x2 = double.Parse(y[0]);
        y2 = double.Parse(y[1]);

        distancia = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        Console.WriteLine(distancia.ToString("F4"));

    }

}