using System;

class URI
{

    static void Main(string[] args)
    {

        int tempo, velocidade;
        tempo = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());

        double litrosNecesserios = tempo * velocidade / 12.00;
        Console.WriteLine(litrosNecesserios.ToString("F3"));

    }

}