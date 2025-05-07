using System;
using System.Collections.Generic;

class Forca
{
    static void Main()
    {
        // Definindo a palavra secreta
        string palavraSecreta = "programacao";
        // Criando uma lista para armazenar as letras da palavra secreta
        List<char> letrasCorretas = new List<char>(new char[palavraSecreta.Length]);
        for (int i = 0; i < letrasCorretas.Count; i++)
            letrasCorretas[i] = '_';

        // Lista de letras erradas
        List<char> letrasErradas = new List<char>();

        // Definindo o número de tentativas
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

            // Verificando se a letra foi repetida
            if (letrasErradas.Contains(letra) || letrasCorretas.Contains(letra))
            {
                Console.WriteLine("Você já tentou essa letra. Tente outra.");
                continue;
            }

            // Verificando se a letra está na palavra secreta
            if (palavraSecreta.Contains(letra))
            {
                // Atualizando as letras corretas
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
                // Se a letra não estiver na palavra secreta, é uma tentativa errada
                letrasErradas.Add(letra);
                tentativas--;
            }
        }

        // Resultado
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
