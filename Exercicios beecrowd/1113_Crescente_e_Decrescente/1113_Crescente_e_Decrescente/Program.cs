using System;

class URI
{

    static void Main(string[] args)
    {

        int X, Y;

        string[] numeros = Console.ReadLine().Split(' ');

        X = int.Parse(numeros[0]);
        Y = int.Parse(numeros[1]);

        while (X != Y)
        {
            if (X < Y)
            {
                Console.WriteLine("Crescente");
            }
            else
            {
                Console.WriteLine("Decrescente");
            }

        }
    }

}