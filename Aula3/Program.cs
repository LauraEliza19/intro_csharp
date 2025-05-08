using System;
using System.Collections.Generic;

class Forca
{
    static void Main()
    {
        string palavraSecreta = "csharp";

        List<char> letrasCorretas = new List<char>(new char[palavraSecreta.Length]);
        for (int i = 0; i < letrasCorretas.Count; i++)
            letrasCorretas[i] = '_';

        List<char> letrasErradas = new List<char>();

        int tentativas = 6;

        while (tentativas > 0 && letrasCorretas.Contains('_'))
        {
            Console.Clear();
            Console.WriteLine("Jogo da Forca!");
            Console.WriteLine("Palavra: " + string.Join(" ", letrasCorretas));
            Console.WriteLine("Letras erradas: " + string.Join(", ", letrasErradas));
            Console.WriteLine("Tentativas restantes: " + tentativas);
            Console.Write("Digite uma letra: ");
            char letra = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (letrasErradas.Contains(letra) || letrasCorretas.Contains(letra))
            {
                Console.WriteLine("Você já tentou essa letra. Tente outra.");
                continue;
            }

            if (palavraSecreta.Contains(letra))
            {
                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    if (palavraSecreta[i] == letra)
                    {
                        letrasCorretas[i] = letra;
                    }
                }
            }
            else
            {
                letrasErradas.Add(letra);
                tentativas--;
            }
        }

        Console.Clear();
        if (!letrasCorretas.Contains('_'))
        {
            Console.WriteLine("Parabéns! Você adivinhou a palavra: " + palavraSecreta);
        }
        else
        {
            Console.WriteLine("Você perdeu! A palavra era: " + palavraSecreta);
        }
    }
}
