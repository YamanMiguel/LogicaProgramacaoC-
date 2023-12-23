using System;

class URI
{

    static void Main(string[] args)
    {

        float x, y;

        string[] coordenadas = Console.ReadLine().Split(' ');

        x = float.Parse(coordenadas[0]);
        y = float.Parse(coordenadas[1]);

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Q2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Q3");
        }
        else
        {
            Console.WriteLine("Q4");
        }

    }

}
