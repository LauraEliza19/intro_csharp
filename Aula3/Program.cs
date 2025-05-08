using System;
using System.Collections.Generic;
using System.Linq;

class Forca
{
  static void Main()
  {
    List<string> dicionario = new List<string> //LISTA DE PALAVRAS
    {
      "BANANA", "COMPUTADOR", "JANELA", "CELULAR", "CACHORRO", "DORMIR",
      "MUSICA", "VIOLAO", "COMIDA", "ROUPA", "TELEVISAO", "JOGO", "FUTEBOL"
    };

    bool jogarNovamente = true;
    Random random = new Random();

    while (jogarNovamente)
    {
      string palavraSecreta = dicionario[random.Next(dicionario.Count)];//PEGA UMA POSIÇÃO (PALAVRA) DO ARRAY DO DICIONARIO
      List<char> letrasCorretas = new List<char>(new char[palavraSecreta.Length]);//LISTA DELETRAS COM O TAMANHO DA PALAVRA
      for (int i = 0; i < letrasCorretas.Count; i++)
        letrasCorretas[i] = '_';//INICIALIZA O ARRAY COM OS UNDERSCORE '_'

      List<char> letrasErradas = new List<char>();//LISTA DE LETRAS ERRADAS
      int tentativas = 6;

      while (tentativas > 0 && letrasCorretas.Contains('_'))//ENQT HOUVER TENTATIVAS E ESPAÇOS VAZIOS
      {
        Console.Clear();
        Console.WriteLine("Jogo da Forca!");
        Console.WriteLine("Palavra: " + string.Join(" ", letrasCorretas));//SE A LETRA ESTIVER NA PALAVRA, RETIRA O _ E INSERE ELA
        Console.WriteLine("Letras erradas: " + string.Join(", ", letrasErradas));//SE A LETRA ESTIVER ERRADA, ADICIONA NO ARRAY DE LETRAS ERRADAS
        Console.WriteLine("Tentativas restantes: " + tentativas);
        Console.Write("Digite uma letra: ");

        char letra = Char.ToUpper(Console.ReadKey(true).KeyChar);//DEIXA MAIUSCULA
        Console.WriteLine("Letra escolhida: " + letra);

        if (!char.IsLetter(letra))
        {
          Console.WriteLine("Por favor, digite apenas letras.");
          Console.ReadKey();
          continue;
        }

        if (letrasErradas.Contains(letra) || letrasCorretas.Contains(letra))
        {
          Console.WriteLine("Você já tentou essa letra. Tente outra.");
          Console.ReadKey();
          continue;
        }

        if (palavraSecreta.Contains(letra))//SE O CHUTE ESTIVER NA PLAAVRA
        {
          for (int i = 0; i < palavraSecreta.Length; i++)//LOOP ATÉ O FIM DA PALAVRA SECRETA
          {
            if (palavraSecreta[i] == letra)//VERIFICA A LETRA ESCOLHIDA COM A POSIÇÃO DO ARRAY
              letrasCorretas[i] = letra;//LETRA CORRETA NA POSIÇÃO i RECEBE O CHUTE
          }
        }
        else
        {
          letrasErradas.Add(letra);//SE FOR UM CHUTE ERRADO, ADICIONA A LETRA AO ARRAY DE LETRAS ERRADAS
          tentativas--;//PERDE UMA TENTATIVA
        }
      }

      Console.Clear();
      if (!letrasCorretas.Contains('_'))
      {
        Console.WriteLine("Parabéns! Você adivinhou a palavra: " + palavraSecreta);
        Console.WriteLine("Erros cometidos: " + letrasErradas.Count);//METODO PRA CONTAR A QTD DE ELEMENTOS DENTOR DO ARRAY
        Console.WriteLine("Letras erradas: " + string.Join(", ", letrasErradas));
      }
      else
      {
        Console.WriteLine("Você perdeu! A palavra era: " + palavraSecreta);
        Console.WriteLine("Letras erradas: " + string.Join(", ", letrasErradas));//JOIN PRA INSERIR VIRGULA ENTRE OS ELEMENTOS
        Console.WriteLine("Erros cometidos: " + letrasErradas.Count);
      }

      Console.WriteLine();
      Console.Write("Jogar de novo? (S/N): ");
      char resposta = Char.ToUpper(Console.ReadKey(true).KeyChar);
      jogarNovamente = (resposta == 'S');//SE S, REINICIA, SE N EXIBE A MSG
    }

    Console.WriteLine("\nObrigado por jogar!");
  }
}
