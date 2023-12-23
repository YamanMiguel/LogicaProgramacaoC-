using System;

class URI
{

    static void Main(string[] args)
    {

        double A, B, media;
        A = double.Parse(Console.ReadLine()) * (3.5 / 11);
        B = double.Parse(Console.ReadLine()) * (7.5 / 11);


        media = A + B;

        Console.WriteLine("MEDIA = " + media.ToString("F5"));
    }

}