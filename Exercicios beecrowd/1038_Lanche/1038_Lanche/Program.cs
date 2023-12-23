using System;

class URI
{

    static void Main(string[] args)
    {

        string[] pedido = Console.ReadLine().Split(' ');

        int codItem = int.Parse(pedido[0]);
        int qtdItem = int.Parse(pedido[1]);
        double preco = 0.0;

        switch (codItem)
        {
            case 1:
                preco = qtdItem * 4.00;

                break;

            case 2:
                preco = qtdItem * 4.50;
                break;

            case 3:
                preco = qtdItem * 5.00;
                break;

            case 4:
                preco = qtdItem * 2.00;
                break;

            case 5:
                preco = qtdItem * 1.50;
                break;

        }
        Console.WriteLine("Total: R$ " + preco.ToString("F2"));


    }

}
