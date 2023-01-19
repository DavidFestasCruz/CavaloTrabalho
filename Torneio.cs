using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    [Serializable]
    public static class Torneio
    {
        public static int participantes;
        public static int recompensa;
        public static int position;

        public static string race(Cavalo cavalo, Equipa jogador)
        {
            int lugar;

            Random rnd = new Random();
            participantes = rnd.Next(1, 10);

            position = cavalo.Velocidade / (cavalo.Idade/2) * (cavalo.Stamina / 3);

            recompensa = 1000;

            Console.WriteLine("A corrida está prestes a começar!");
            Console.WriteLine("Prosseguir");
            Console.ReadKey();
            Console.Clear();

            if(position > participantes)
            {
                jogador.Dinheiro = jogador.Dinheiro + recompensa;
                return "O jogador terminou a corrida em 1º lugar! O jogador recebeu " + recompensa + " moedas!";
            }
            else
            {
                jogador.Dinheiro = jogador.Dinheiro - (recompensa / 2);
                return "O jogador terminou a corrida em " + participantes + "º lugar! O jogador predeu 500 moedas";
            }
        }
    }
}
