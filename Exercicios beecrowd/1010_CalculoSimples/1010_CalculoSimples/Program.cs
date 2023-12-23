/using System; 

class URI
{

    static void Main(string[] args)
    {

        string[] produto1 = Console.ReadLine().Split(' ');
        string[] produto2 = Console.ReadLine().Split(' ');

        int codProduto1 = int.Parse(produto1[0]);
        int qtdProduto1 = int.Parse(produto1[1]);
        double precoProduto1 = double.Parse(produto1[2]);
        double somaProduto1 = (qtdProduto1 * precoProduto1);

        int codProduto2 = int.Parse(produto2[0]);
        int qtdProduto2 = int.Parse(produto2[1]);
        double precoProduto2 = double.Parse(produto2[2]);
        double somaProduto2 = (qtdProduto2 * precoProduto2);

        double precoFinal = (somaProduto1 + somaProduto2);

        Console.WriteLine("VALOR A PAGAR: R$ " + precoFinal.ToString("F2"));

    }

}