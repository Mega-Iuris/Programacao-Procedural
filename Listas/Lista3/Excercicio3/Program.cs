using System;

class Program 
{
    static void Main(string []args)
    {
        const string NOME_USUARIO = "admin";
        const string SENHA_USUARIO = "123senha";
        const int NUMERO_MAXIMO_TENTATIVAS = 3;

        int contadorTentativas = 0;

        do
        {
            Console.Write("Digite seu nome de usuário: ");
            string nomeLogin = Console.ReadLine(); 
            Console.Write("Digite sua senha de acesso: ");
            string senhaAcesso = Console.ReadLine();


            Console.WriteLine("");
            if(NOME_USUARIO == nomeLogin && SENHA_USUARIO == senhaAcesso)
            {
                Console.WriteLine("Login realizado com sucesso! \n");
                break;
            }
            else
            {
                contadorTentativas++;

                if(contadorTentativas == NUMERO_MAXIMO_TENTATIVAS)
                {
                    Console.WriteLine("Sua conta foi bloqueada!\n");
                }
                else
                {
                    Console.WriteLine("Nome de usuário ou senha incorretos, tente novamente!\n");
                }
            }
        }
        while(contadorTentativas < NUMERO_MAXIMO_TENTATIVAS);        
    }
}