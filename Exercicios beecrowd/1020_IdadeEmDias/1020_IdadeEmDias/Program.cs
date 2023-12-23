using System;

class URI
{

    static void Main(string[] args)
    {

        int N, resto, quociente, dias;

        N = int.Parse(Console.ReadLine());

        quociente = N / 365;
        Console.WriteLine(quociente + " ano(s)");
        resto = N % 365;

        quociente = resto / 30;
        Console.WriteLine(quociente + " mes(es)");
        dias = resto % 30;
        Console.WriteLine(dias + " dia(s)");

    }

}
