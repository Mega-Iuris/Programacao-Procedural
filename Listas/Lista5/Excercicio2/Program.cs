using System;
class Program 
{
    static void Main(string[]args)
    {
        for (int i = 10; i >= 1; i--)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
}