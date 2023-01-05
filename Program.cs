using CavalosTrabalho;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipa Player1 = new Equipa("Equipa 1", "None", 500, 1);
            Cavalo Basico = new Cavalo("Fraco", 2, 2, 10, 250);
            Cavalo Intermedio = new Cavalo("Medio", 10, 10, 10, 1500);
            Cavalo Forte = new Cavalo("Forte", 18, 18, 10, 3000);
            Dias Dia = new Dias(0);


            Console.WriteLine("Bem-Vindo ao jogo dos cavalos de corrida!!!");
            Console.Write("                                 |\\    /|\r\n                              ___| \\,,/_/\r\n                           ---__/ \\/    \\\r\n                          __--/     (D)  \\\r\n                          _ -/    (_      \\\r\n                         // /       \\_ /  -\\\r\n   __-------_____--___--/           / \\_ O o)\r\n  /                                 /   \\__/\r\n /                                 /\r\n||          )                   \\_/\\\r\n||         /              _      /  |\r\n| |      /--______      ___\\    /\\  :\r\n| /   __-  - _/   ------    |  |   \\ \\\r\n |   -  -   /                | |     \\ )\r\n |  |   -  |                 | )     | |\r\n  | |    | |                 | |    | |\r\n  | |    < |                 | |   |_/\r\n  < |    /__\\                <  \\\r\n  /__\\                       /___\\");
            Console.WriteLine("\nClique para começar...");
            Console.ReadKey();
            Console.Clear();

            while (Player1.Dinheiro >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("[Dinheiro atual: " + Player1.Dinheiro + " | Dia atual: " + Dia.diaHoje() + "]\n\n");
                Console.WriteLine("Escolha o seu cavalo!!!\n\n");
                Console.WriteLine("[Basico]");
                Console.WriteLine(Basico);
                Console.WriteLine("--------------------\n\n");
                Console.WriteLine("[Intermedio]");
                Console.WriteLine(Intermedio);
                Console.WriteLine("--------------------\n\n");
                Console.WriteLine("[Forte]");
                Console.WriteLine(Forte);
                string EscolhaJogador = Console.ReadLine();
                Player1.Cavalo = VendedorCavalos.getCavalo(EscolhaJogador, Player1);
                while (Player1.Cavalo == null)
                {
                    EscolhaJogador = Console.ReadLine();
                    Player1.Cavalo = VendedorCavalos.getCavalo(EscolhaJogador, Player1);
                }

                Console.WriteLine("\n\nVocê comprou o cavalo " + Player1.Cavalo.Nome);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("[Dinheiro atual: " + Player1.Dinheiro + " | Dia atual: " + Dia.diaHoje() + "]\n\n");
                Console.ReadKey();

            }

            Console.Clear();
            Console.WriteLine("Game Over");
        }
    }
}