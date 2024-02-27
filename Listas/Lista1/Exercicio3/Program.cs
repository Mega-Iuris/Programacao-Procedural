using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de moedas de um centavo: ");
        
        int centavos = toString32(Console.ReadLine());

        int reais = centavos / 100;
        int restoCentavos = centavos % 100;

        Console.WriteLine($"O total em dinheiro eh: {reais} real(is) e {restoCentavos} centavo(s)");
    }
}