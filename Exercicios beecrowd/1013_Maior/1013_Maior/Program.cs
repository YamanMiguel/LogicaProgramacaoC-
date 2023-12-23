using System;

class URI
{

    static void Main(string[] args)
    {

        int A, B, C, maiorAB, maiorC;
        string[] ABC = Console.ReadLine().Split(' ');
        A = int.Parse(ABC[0]);
        B = int.Parse(ABC[1]);
        C = int.Parse(ABC[2]);

        maiorAB = (A + B + Math.Abs(A - B)) / 2;
        maiorC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

        Console.WriteLine(maiorC + " eh o maior");

    }

}