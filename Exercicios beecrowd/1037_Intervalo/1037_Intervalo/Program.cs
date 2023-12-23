using System;

class URI
{

    static void Main(string[] args)
    {

        double x = double.Parse(Console.ReadLine());

        if (x >= 0.00 && x <= 25.01)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (x >= 25.00 && x <= 50.01)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (x >= 50.00 && x <= 75.01)
        {
            Console.WriteLine("Intervalo [50,75]");
        }
        else if (x >= 75.00 && x <= 100.01)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }

    }

}
