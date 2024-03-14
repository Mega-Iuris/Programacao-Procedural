using System;

class Program
{
    static void Main(string []args)
    {
        int altura = 0;

        do
        {
            Console.Write($"Digite um valor entre (1 e 9): ");
            altura = Convert.ToInt32(Console.ReadLine());
        }
        while(altura < 1 || altura > 9);

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }

}