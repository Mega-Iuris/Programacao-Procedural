using System;

class Program
{
    static void Main(String[]args)
    {
        System.Console.Write("Digite o nome do aluno ");
        //Usei essa sintaxe para não mostra as mensagens de "warning" no codigo.
        string? nomeAluno = Console.ReadLine();

        System.Console.Write("Digite a 1º nota do aluno ");
        //Usei o "Convert.ToDouble" no lugar de "double.Parse" para não mostra as mensagens de "warning" 
        //nas linhas do "Console.ReadLine()" e nem quando roda o codigo.
        double nota1 = Convert.ToDouble(Console.ReadLine());
        
        System.Console.Write("Digite a 2º nota do aluno ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        
        System.Console.Write("Digite a 3º nota do aluno ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Digite a 4º nota do aluno ");
        double nota4 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media >= 5.0)
        {
            System.Console.WriteLine($" Aluno {nomeAluno} foi aprovado com a media de: {media}");
        } 
        else if (media < 5.0 && media  >= 3.0)
        {
            System.Console.WriteLine($" Aluno {nomeAluno} esta em recuperacao com a media de: {media}");
        }
        else
        {
            System.Console.WriteLine($" Aluno {nomeAluno} foi reprovado com a media de: {media}");;
        }

    }
}