using System;
using System.Drawing;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;

            for (int i = 1; i <= N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }

            Console.WriteLine(soma);



            for(int i = 0; i < 5; i++) {
                Console.WriteLine("Valor de i: " +i);
            }





        }
    }
}