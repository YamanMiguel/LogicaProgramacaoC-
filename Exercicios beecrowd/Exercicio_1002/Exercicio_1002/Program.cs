using System;

class URI
{

    static void Main(string[] args)
    {

        double area, n, raio;
        raio = double.Parse(Console.ReadLine());
        n = 3.14159;
        area = n * Math.Pow(raio, 2);

        Console.WriteLine("A=" + area.ToString("F4"));

    }

}