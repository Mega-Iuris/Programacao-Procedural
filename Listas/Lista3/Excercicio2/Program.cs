using System;

class Program
{
    static void Main(string[] agrs)
    {
        const double FRETE_GRATIS = 150;
        int itensComprados = 1;
        double totalCompras = 0;
        double ValorItemCompra = 0;

        System.Console.WriteLine("Digite a quantidade de itens que voce comprou ");
        int quantidadeItens = Convert.ToInt32(Console.ReadLine());

        while (quantidadeItens >= itensComprados)
        {
            System.Console.Write($"Digite o valor do {itensComprados}º comprado valor R$ ");
            ValorItemCompra = Convert.ToDouble(Console.ReadLine());

            totalCompras += ValorItemCompra;
            itensComprados++;
        }

        if (totalCompras >= FRETE_GRATIS)
        {
            System.Console.WriteLine($"Parabéns! Você ganhou frete grátis em sua compra de valor R$ {Math.Round(totalCompras, 2)}");
        }
        else
        {
            System.Console.WriteLine($"A compra não possui frete grátis");
        }
    }
}
