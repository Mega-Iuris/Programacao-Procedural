using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite o valor para a Base do Triangulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor para a Altura do Triangulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double area = (baseTriangulo * alturaTriangulo) / 2;
        bool validadorTriangulo = area > 20;

        Console.WriteLine("");
        Console.WriteLine($"A area do triangulo eh maior que 20? {validadorTriangulo}");

    }

}