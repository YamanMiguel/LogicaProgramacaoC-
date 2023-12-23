using System;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C, pi, triangulo, circulo, trapezio, quadrado, retangulo;

        string[] ABC = Console.ReadLine().Split(' ');

        A = double.Parse(ABC[0]);
        B = double.Parse(ABC[1]);
        C = double.Parse(ABC[2]);
        pi = 3.14159;
        triangulo = A * C / 2;
        circulo = pi * Math.Pow(C, 2);
        trapezio = (A + B) * (C / 2);
        quadrado = Math.Pow(B, 2);
        retangulo = A * B;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));


    }

}