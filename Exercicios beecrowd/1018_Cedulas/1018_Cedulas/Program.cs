using System;

class URI
{

    static void Main(string[] args)
    {

        int N, n100, resto100, n50, resto50, n20, resto20, n10, resto10, n5, resto5, n2, resto2, n1;

        N = int.Parse(Console.ReadLine());

        n100 = N / 100;
        resto100 = N % 100;

        n50 = resto100 / 50;
        resto50 = resto100 % 50;

        n20 = resto50 / 20;
        resto20 = resto50 % 20;

        n10 = resto20 / 20;
        resto10 = resto20 % 20;

        n5 = resto10 / 5;
        resto5 = resto10 % 5;

        n2 = resto5 / 2;
        resto2 = resto5 % 2;

        n1 = resto2 / 1;

        Console.WriteLine(N);
        Console.WriteLine(n100 + " nota(s) de R$ 100,00");
        Console.WriteLine(n50 + " nota(s) de R$ 50,00");
        Console.WriteLine(n20 + " nota(s) de R$ 20,00");
        Console.WriteLine(n10 + " nota(s) de R$ 10,00");
        Console.WriteLine(n5 + " nota(s) de R$ 5,00");
        Console.WriteLine(n2 + " nota(s) de R$ 2,00");
        Console.WriteLine(n1 + " nota(s) de R$ 1,00");

    }

}
