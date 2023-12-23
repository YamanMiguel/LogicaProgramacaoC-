using System;

class URI
{

    static void Main(string[] args)
    {

        int numero, horas;
        double salarioPorHora, salario;

        numero = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());
        salarioPorHora = double.Parse(Console.ReadLine());

        salario = horas * salarioPorHora;


        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));

    }

}