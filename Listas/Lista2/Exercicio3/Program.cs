using System;

class Program
{
    static void Main(String[]args)
    {
        System.Console.WriteLine("Por favor, digite: \n 1 - Se deseja rotina da Filomena \n 2 - Se deseja rotina do Joselito");
        int rotina = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("");

        if(rotina ==1)
        {
            System.Console.WriteLine("Rotina de Filomena: \n 1. Escola das 07h as 12h \n 2. Almoço das 12h as 13h \n 3. Futebol das 14h as 16h \n 4. Dever de casa das 16h as 18h");
        }
        else if ( rotina == 2)
        {
            System.Console.WriteLine("Rotina de Joselito: \n 1. Escola das 07h as 12:30h \n 2. Almoço das 13h as 14h \n 3. Natação das 14h as 16h \n 4. Reforço escolar das 16h as 19h");
        }
        else
        {
            System.Console.WriteLine("Voce digitou um valor invalido!");
        }
        System.Console.WriteLine("");
    }
}