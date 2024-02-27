using System;

class Program 
{
    static void Main(string[] args)
    {
        const string nomePadrao = "admin";
        const string senhaPadrao = "123senha";

        Console.Write("Digite o nome do usuário: ");
        string nome = Console.ReadLine();
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();

        if (nome == nomePadrao && senha == senhaPadrao)
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais inválidas");
        }
    }
}
