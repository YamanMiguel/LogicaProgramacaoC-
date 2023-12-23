using System;

class URI
{

    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());

        double kmLitros = X / Y;

        Console.WriteLine(kmLitros.ToString("F3") + " km/l");

    }

}