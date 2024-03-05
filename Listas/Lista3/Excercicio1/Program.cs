using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_HABITANTES = 20;
        double mediaSalario = 0;
        int mediaFilhos = 0;
        double maiorSalario = 0;

        for (int i = 1; i <= NUMERO_HABITANTES; i++)
        {
            System.Console.Write($"Digite salario da {i}ª pessoa: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            mediaSalario += salario;

            System.Console.Write($"Digite a quantida de filhos da {i}ª pessoa: ");
            int numeroFilhos = Convert.ToInt32(Console.ReadLine());
            mediaFilhos += numeroFilhos;

            System.Console.WriteLine("");

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }
        }

        Console.WriteLine($"Media salarial = R$ {Math.Round(mediaSalario / NUMERO_HABITANTES, 2)}");
        Console.WriteLine($"Media de filhos por habitantes = {mediaFilhos / NUMERO_HABITANTES}");
        Console.WriteLine($"Maior salario = R$ {Math.Round(maiorSalario, 2)}");
    }
}
