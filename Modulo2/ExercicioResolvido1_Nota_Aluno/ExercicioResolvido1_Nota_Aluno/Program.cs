using System;
using System.Globalization;

namespace notasAluno
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a nota da primeira prova:");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota da segunda prova:");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = nota1 + nota2;

            if (notaFinal < 60.0)
            {
                Console.WriteLine("Nota Final: " + notaFinal.ToString(CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Reprovado!");
            }
            else
            {
                Console.WriteLine("Nota Final: " + notaFinal.ToString(CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Aprovado!");
            }

        }
    }
}