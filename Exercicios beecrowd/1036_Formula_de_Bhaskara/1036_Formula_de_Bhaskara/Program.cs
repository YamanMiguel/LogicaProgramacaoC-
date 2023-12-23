using System;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C, bhaskara, R1, R2;

        string[] ABC = Console.ReadLine().Split(' ');

        A = double.Parse(ABC[0]);
        B = double.Parse(ABC[1]);
        C = double.Parse(ABC[2]);

        bhaskara = Math.Pow(B, 2.0) - (4 * A * C);

        if (A == 0.0 || bhaskara < 0.0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            R1 = (-B + Math.Sqrt(bhaskara)) / (2.0 * A);
            R2 = (-B - Math.Sqrt(bhaskara)) / (2.0 * A);

            Console.WriteLine("R1 = " + R1.ToString("F5"));
            Console.WriteLine("R2 = " + R2.ToString("F5"));
        }
    }

}