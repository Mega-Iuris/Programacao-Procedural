﻿using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

        Console.WriteLine("");
        Console.WriteLine($" {nome}, a sua média é: {media}");
    }
}
