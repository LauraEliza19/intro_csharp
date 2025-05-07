//----------------------------------------------------//--------------------------------------------------
//ex 1 Pedra Papel Tesoura
using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("Escolha entre 1 para pedra, 2 para papel ou 3 para tesoura: ");
        string entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int escolha) || escolha < 1 || escolha > 3)
        {
            Console.WriteLine("Escolha inválida. Tente novamente.");
            return;
        }

        int pc_escolha_num = rand.Next(1, 4);

        string escolha_nome = escolha switch
        {
            1 => "1 - Pedra",
            2 => "2 - Papel",
            3 => "3 - Tesoura"
        };

        string pc_escolha_nome = pc_escolha_num switch
        {
            1 => "1 - Pedra",
            2 => "2 - Papel",
            3 => "3 - Tesoura"
        };

        Console.WriteLine($"Você escolheu: {escolha_nome}.");
        Console.WriteLine($"PC escolheu: {pc_escolha_nome}.");

        if (escolha == pc_escolha_num)
        {
            Console.WriteLine("Empate");
        }
        else if ((escolha == 1 && pc_escolha_num == 3) ||
                 (escolha == 2 && pc_escolha_num == 1) ||
                 (escolha == 3 && pc_escolha_num == 2))
        {
            Console.WriteLine("Você ganhou!");
        }
        else
        {
            Console.WriteLine("Você perdeu.");
        }
    }
}


