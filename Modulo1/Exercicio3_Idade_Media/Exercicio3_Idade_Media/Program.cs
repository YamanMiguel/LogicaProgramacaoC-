using System;
using System.Globalization;

namespace IdadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos calcular a idade média entre duas pessoas");
            Console.WriteLine("Digite apenas o primeiro nome e a idade:");
            string[] PrimeiraPessoa = Console.ReadLine().Split(' ');
            Console.WriteLine("Digite apenas o primeiro nome e a idade:");
            string[] SegundaPessoa = Console.ReadLine().Split(' ');

            string nomePrimeiraPessoa = PrimeiraPessoa[0];
            int idadePrimeiraPessoa = int.Parse(PrimeiraPessoa[1]);

            string nomeSegundaPessoa = SegundaPessoa[0];
            int idadeSegundaPessoa = int.Parse(SegundaPessoa[1]);

            double mediaIdades = (idadePrimeiraPessoa + idadeSegundaPessoa) / 2.0;

            Console.WriteLine("A idade média de " + nomePrimeiraPessoa + " e " + nomeSegundaPessoa + " é de: " + mediaIdades.ToString(CultureInfo.InvariantCulture) + " anos.");



        }
    }
}