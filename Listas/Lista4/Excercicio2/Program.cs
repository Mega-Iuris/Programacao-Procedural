using System;

class Program
{
    static void Main(string[] args)
    {
        int altura = 0;
        bool alturaValida = false;

        while (alturaValida == false)
        {
            Console.Write($"Digite um valor entre 1 e 9: ");
            altura = Convert.ToInt32(Console.ReadLine());

            if (altura >= 1 && altura <= 9)
            {
                alturaValida = true;
            }
            else
            {
                Console.Write("altura invalida, insira uma altura entre 1 e 9: ");
            }

        }

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
