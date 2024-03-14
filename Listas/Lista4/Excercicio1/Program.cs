using System;

class Program
{
    static void Main(string []args)
    {
        const int PRODUTO = 10;

        for (int i = 1; i <= PRODUTO; i++)
        {
            for (int j = 1; j <= PRODUTO; j++)
            {
                Console.WriteLine($"{i} X {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
}
