using CavalosTrabalho;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    [Serializable]
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objeto jogador
            Equipa Player1 = new Equipa("Equipa 1", "None", 1000, 1);

            //Objeto cavalos
            Cavalo Basico = new Cavalo("Fraco", 250, 5, 5, 30);
            Cavalo Intermedio = new Cavalo("Medio", 1500, 10, 10, 20);
            Cavalo Forte = new Cavalo("Forte", 3000, 18, 18, 10);

            Staff staffTeam = new Staff(1, 10);

            //Introduçao
            Console.WriteLine("Bem-Vindo ao jogo dos cavalos de corrida!!!");
            Console.Write("                                 |\\    /|\r\n                              ___| \\,,/_/\r\n                           ---__/ \\/    \\\r\n                          __--/     (D)  \\\r\n                          _ -/    (_      \\\r\n                         // /       \\_ /  -\\\r\n   __-------_____--___--/           / \\_ O o)\r\n  /                                 /   \\__/\r\n /                                 /\r\n||          )                   \\_/\\\r\n||         /              _      /  |\r\n| |      /--______      ___\\    /\\  :\r\n| /   __-  - _/   ------    |  |   \\ \\\r\n |   -  -   /                | |     \\ )\r\n |  |   -  |                 | )     | |\r\n  | |    | |                 | |    | |\r\n  | |    < |                 | |   |_/\r\n  < |    /__\\                <  \\\r\n  /__\\                       /___\\");
            Console.WriteLine("\nClique para começar...");
            Console.ReadKey();
            Console.Clear();

            //Regras do Jogo
            Console.WriteLine("Como jogar?");
            Console.WriteLine("\n- O jogador vai, primeiramente, escolher o seu cavalo inicial. A cada 40 dias, o jogador pode comprar um cavalo novo;");
            Console.WriteLine("- Todos os dias, o jogador terá que cuidar do seu cavalo, controlar a staff e competir em torneios para ganhar mais dinheiro. Os torneios ocorrem de 10 em 10 dias.");
            Console.WriteLine("- Para além das funções normais do jogador, este estará também sujeito a eventos diários que iram mudar o rumo do jogo no bom ou no mau sentido;");
            Console.WriteLine("- O jogo termina quando o jogador ficar sem dinheiro.");
            Console.WriteLine("\nClique em qualquer tecla para iniciar o jogo.");
            Console.ReadKey();
            Console.Clear();

            //Compra do cavalo inicial
            Console.WriteLine("[Dinheiro atual: " + Player1.Dinheiro + " | Dia atual: " + Dias.nextDay() + "]\n\n");
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

            //Jogo acaba qnd o jogador for a falencia
            while (Player1.Dinheiro >= 0)
            {
                Console.Clear();
                //Dinheiro e dia
                Console.WriteLine("[Dinheiro atual: " + Player1.Dinheiro + " | Dia atual: " + Dias.nextDay() + "]\n\n");
                
                //Evento Diario
                Console.WriteLine("Daily event");
                Console.WriteLine(Dias.dailyEvent(Player1.Cavalo));
                Console.ReadKey();
                Console.Clear();

                //Tratar Cavalo
                //string escolherTratar = Console.ReadLine();
                //Console.WriteLine(Cavalo.tratarCavalo(escolherTratar, staffTeam, Player1));
                //Console.ReadKey();
                //Console.Clear();

                //Comprar staff;
                //Console.WriteLine("Dejesa contratar um membro de staff?");
                //string comprarStaff = Console.ReadLine();
                //Player1.Staff = buyStaff.getStaff(comprarStaff);

                //while (comprarStaff != "N" || comprarStaff != "S")
                //{
                //comprarStaff = Console.ReadLine();
                //Player1.Staff = buyStaff.getStaff(EscolhaJogador);
                //}

                //Status do cavalo
                Console.WriteLine("\n\nStatus do cavalo:");
                Console.WriteLine("\nNome: " + Player1.Cavalo.Nome);
                Console.WriteLine("\nVelocidade: " + Player1.Cavalo.Velocidade);
                Console.WriteLine("\nStamina: " + Player1.Cavalo.Stamina);
                Console.WriteLine("\nIdade: " + Player1.Cavalo.Idade);
                Console.WriteLine("\nStatus: Normal");
                Console.ReadKey();
                Console.Clear();

                //Corrida
                if (Dias.dia % 10 == 0)
                {
                    Console.WriteLine(Torneio.race( Player1));
                    Console.ReadKey();
                }
              

                if (Dias.dia % 40 == 0)
                {
                    Console.WriteLine("[Dinheiro atual: " + Player1.Dinheiro + " | Dia atual: " + Dias.nextDay() + "]\n\n");
                    Console.WriteLine("Escolha o seu cavalo!!!\n\n");
                    Console.WriteLine("[Basico]");
                    Console.WriteLine(Basico);
                    Console.WriteLine("\n--------------------\n");
                    Console.WriteLine("[Intermedio]");
                    Console.WriteLine(Intermedio);
                    Console.WriteLine("\n--------------------\n");
                    Console.WriteLine("[Forte]");
                    Console.WriteLine(Forte);
                    string EscolhaJogador2 = Console.ReadLine();
                    Player1.Cavalo = VendedorCavalos.getCavalo(EscolhaJogador2, Player1);

                    while (Player1.Cavalo == null)
                    {
                        EscolhaJogador2 = Console.ReadLine();
                        Player1.Cavalo = VendedorCavalos.getCavalo(EscolhaJogador2, Player1);
                    }

                    Console.WriteLine("\n\nVocê comprou o cavalo " + Player1.Cavalo.Nome);
                    Console.ReadKey();
                }
            }
            //Fim do jogo
            Console.Clear();
            Console.WriteLine("Fim do Jogo");
        }
    }
}