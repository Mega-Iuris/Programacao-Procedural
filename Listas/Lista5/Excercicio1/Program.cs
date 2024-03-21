using System;
class Program
{
    static void Main(string[] args)
    {
        int decrescente = 200;
        int crescente = 100;

        for (int i = 0; i <= crescente; i += 2)
        {
            Console.WriteLine($"{i} - {decrescente}");
            decrescente -= 4;
        }
    }
}