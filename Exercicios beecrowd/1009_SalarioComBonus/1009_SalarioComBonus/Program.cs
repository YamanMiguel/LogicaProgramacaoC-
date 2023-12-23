using System;

class URI
{

    static void Main(string[] args)
    {

        double salarioFixo, totalVendas, total;
        string nome = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine());
        totalVendas = double.Parse(Console.ReadLine());

        total = salarioFixo + (totalVendas * 15 / 100);

        Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));

    }

}
