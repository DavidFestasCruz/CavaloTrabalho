using CavalosTrabalho;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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

            Cavalo Basico = new Cavalo("Fraco",  250, 2, 2, 10, ConsoleColor.Gray);
            Cavalo Intermedio = new Cavalo("Medio", 1500, 10, 10, 10, ConsoleColor.Red);
            Cavalo Forte = new Cavalo("Forte", 3000, 18, 18, 10, ConsoleColor.Green);

            Dias Dia = new Dias(0);

            int trackLength = 50;



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

                Console.WriteLine("Press enter to start the race!");
                Console.ReadLine();
                Console.Clear();
                DisplayRace(cavalos, trackLength);


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

                bool raceInProgress = true;
                while (raceInProgress)
                {
                    Random rnd = new Random();

                    foreach (Cavalo c in cavalos)
                    {
                        int distance = rnd.Next(1, c.Velocidade + 1);
                        c.Move(distance);
                    }

                    Console.Clear();
                    DisplayRace(cavalos, trackLength);
                }

                static void DisplayRace(Cavalo[] c, int trackLength)
                {
                    // Display the track
                    Console.WriteLine("Track:");
                    for (int i = 0; i < trackLength; i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();

                    // Display the horses
                    foreach (Cavalo ca in cavalos)
                    {
                        Console.ForegroundColor = ca.Cor;
                        Console.Write(new string('*', ca.Posicao));
                        Console.ResetColor();
                        Console.WriteLine(" " + ca.Nome);
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Game Over");
        }
    }
}