using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write($"Digite a altura do retangulo: ");
        int alturaDoRetangulo = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Digite a largura do retangulo: ");
        int larguraDoRetangulo = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();

        for (int i = 0; i < alturaDoRetangulo; i++)
        {
            for (int j = 0; j < larguraDoRetangulo; j++)
            {
                Console.Write($"*");
            }
            Console.WriteLine();
        }
    }
}