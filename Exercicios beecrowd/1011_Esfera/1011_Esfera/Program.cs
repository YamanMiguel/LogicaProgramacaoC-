using System;

class URI
{

    static void Main(string[] args)
    {

        double R = double.Parse(Console.ReadLine());
        double pi = 3.14159; 
        double volume = (4.0 / 3.0) * pi * Math.Pow(R, 3);
        
        Console.WriteLine("VOLUME = " + volume.ToString("F3"));

    }

}