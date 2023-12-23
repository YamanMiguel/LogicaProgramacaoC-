using System;
using System.Globalization;

namespace ExercicioResolvido3
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;


            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            //Leitura de dados
            for (int i = 0; i < N; i++)
            {
                string[] pessoas = Console.ReadLine().Split(' ');
                nomes[i] = pessoas[0];
                idades[i] = int.Parse(pessoas[1]);
                alturas[i] = double.Parse(pessoas[2], CultureInfo.InvariantCulture);
            }

            //Calcular altura media das pessoas

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma += alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));


            //Calcular porcetagem de pessoas com menos de 16

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont ++;
                }       
            }
            double porcentagem = (double) cont / N * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

        }

    }
}