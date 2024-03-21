using System;
class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;
        do
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 0)
            {
                break;
            }
            else if (numero % 2 == 1)
            {
                somatorio += numero;
            }

        }
        while (true);

        Console.WriteLine($"O somatorio de impares eh: {somatorio}");
    }
}