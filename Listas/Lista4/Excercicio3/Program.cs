using System;

class Program
{
    static void Main(string []args)
    {
        const int COLUNAS = 7;
        const int LINHAS = 7;

        Tabuleiro.InicializaTabuleiro();

        for (int i = 0; i <= COLUNAS; i++)
        {
            for (int j = 0; j <= LINHAS; j++)
            {
                if (i == 0 || i == LINHAS || j == 0 || j == COLUNAS)
                {
                    Tabuleiro.Adicionar(i, j, "S");
                }
            }
        }

        Tabuleiro.ImprimeTabuleiro();
    }
}