using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    public class Cavalo
    {
        public List<Cavalo> cavalos;
        private string nome;
        private int preco;
        private int velocidade;
        private int stamina;
        private int posicao;
        private ConsoleColor cor;

        public Cavalo(string nome, int preco, int velocidade, int stamina, int posicao, ConsoleColor cor)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Velocidade = velocidade;
            this.Stamina = stamina;
            this.Posicao = posicao;
            this.Cor = ConsoleColor.Gray;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Preco { get => preco; set => preco = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int Posicao { get => posicao; set => posicao = value; }
        public ConsoleColor Cor { get => cor; set => cor = value; }

        public void Move(int distance)
        {
            Posicao += distance;
        }
        public override string ToString()
        {
            return "O cavalo " + Nome + " custa " + Preco + " moedas, possui " + Velocidade + " de velocidade e " + Stamina + " de stamina.";
        }
    }
}
