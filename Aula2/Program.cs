//----------------------------------------------------//--------------------------------------------------
//ex 2
using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("Quantas vezes deseja jogar o dado? ");
        if (!int.TryParse(Console.ReadLine(), out int jogadas))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        int[] faces = new int[7];

        for (int i = 1; i <= jogadas; i++)
        {
            int resultado = rand.Next(1, 7);
            faces[resultado]++;
            Console.WriteLine($"Jogada {i}: {resultado}");
        }

        Console.WriteLine("\nContagem de cada face:");
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Face {i}: {faces[i]}");
        }
    }
}


        // int outroNumero = rand.Next(1, 11); 

        // int soma = jogadas + outroNumero;

        // Console.WriteLine($"A soma de {jogadas} + {outroNumero} é: {soma}");

        // if (soma % 2 == 0)
        // {
        //     Console.WriteLine("O resultado da soma é PAR.");
        // }
        // else
        // {
        //     Console.WriteLine("O resultado da soma é ÍMPAR.");
        // }

        // if ((escolha == "par" && soma % 2 == 0) || (escolha == "impar" && soma % 2 != 0))
        // {
        //     Console.WriteLine("Você acertou!");
        // }
        // else
        // {
        //     Console.WriteLine("Você errou.");
        // }
//     }
// }
