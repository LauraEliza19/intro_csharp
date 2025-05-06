//----------------------------------------------------//--------------------------------------------------
//ex 1
using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("Escolha entre 'par' ou 'impar': ");
        string escolha = Console.ReadLine().ToLower();

        if (escolha != "par" && escolha != "impar")
        {
            Console.WriteLine("Escolha inválida. Tente novamente.");
            return;
        }

        Console.WriteLine("Informe um número inteiro: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Número inválido. Tente novamente.");
            return;
        }

        int outroNumero = rand.Next(1, 11); 

        int soma = numero + outroNumero;

        Console.WriteLine($"A soma de {numero} + {outroNumero} é: {soma}");

        if (soma % 2 == 0)
        {
            Console.WriteLine("O resultado da soma é PAR.");
        }
        else
        {
            Console.WriteLine("O resultado da soma é ÍMPAR.");
        }

        if ((escolha == "par" && soma % 2 == 0) || (escolha == "impar" && soma % 2 != 0))
        {
            Console.WriteLine("Você acertou!");
        }
        else
        {
            Console.WriteLine("Você errou.");
        }
    }
}
