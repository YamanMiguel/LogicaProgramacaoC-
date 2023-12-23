using System;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C, media;
        A = double.Parse(Console.ReadLine()) * 2 / 10;
        B = double.Parse(Console.ReadLine()) * 3 / 10;
        C = double.Parse(Console.ReadLine()) * 5 / 10;


        media = A + B + C;

        Console.WriteLine("MEDIA = " + media.ToString("F1"));
    }

}