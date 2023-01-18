using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    public class Torneio
    {
        private int participantes;
        private int recompensa;
        private int position;

        public Torneio(int participantes, int recompensa, int position)
        {
            this.participantes = participantes;
            this.recompensa = recompensa;
            this.position = position;
        }

        public int Participantes { get => participantes; set => participantes = value; }
        public int Recompensa { get => recompensa; set => recompensa = value; }
        public int Position { get => position; set => position = value; }

        public string race(Cavalo cavalo, Equipa jogador)
        {
            Random rnd = new Random();
            this.participantes = rnd.Next(1, 21);

            position = cavalo.Velocidade - (cavalo.Idade/2) * (cavalo.Stamina / 10) / this.participantes * rnd.Next(1, 21);
            recompensa = 1000 * (participantes / 10);

            if(position == 1)
            {
                jogador.Dinheiro = jogador.Dinheiro + recompensa;
                return "O jogador terminou a corrida em " + position + "º lugar! O jogador recebeu " + recompensa + " moedas!";
            }
            else
            {
                return "O jogador terminou a corrida em " + position + "º lugar!";
            }
        }
    }
}
