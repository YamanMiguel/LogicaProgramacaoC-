using System;
using System.Globalization;

namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            double[] vet;
            double soma, media;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            soma = 0.0;
            media = 0.0;

            string[] entrada = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");

            }
            
            Console.WriteLine();

            for (int i = 0;i < N; i++)
            {
                soma += vet[i];
            }
            media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}