using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    [Serializable]
    enum Status
        {
        saudavel,
        doente,
        energetico,
        morto
    };
    public class Cavalo
    {
        private string nome;
        private int preco;
        private int velocidade;
        private int stamina;
        private int idade;

        public Cavalo(string nome, int preco, int velocidade, int stamina, int idade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Velocidade = velocidade;
            this.Stamina = stamina;
            this.Idade = idade;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Preco { get => preco; set => preco = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int Idade { get => idade; set => idade = value; }

        public void tratarCavalo(string escolhaTratar, Cavalo cavalo, Staff staff, Equipa equipa)
        {
            Console.WriteLine("O que pretende treinar?\n\n");
            Console.WriteLine("Velocidade\n");
            Console.WriteLine("Stamina\n");
            
            if (escolhaTratar == "Velocidade")
            {
                velocidade = velocidade + 1 * (staff.StaffNumber / 2);
                equipa.Dinheiro = equipa.Dinheiro - 250;
            }
            else if (escolhaTratar == "Stamina")
            {
                stamina = stamina + 1 * (staff.StaffNumber / 2);
                equipa.Dinheiro = equipa.Dinheiro - 250;
            }
            else
            {
                Console.WriteLine("Nada treinado\n");
            }
        }

        public override string ToString()
        {
            return "O cavalo " + Nome + " custa " + Preco + " moedas, possui " + Velocidade + " de velocidade e " + Stamina + " de stamina. Este cavalo tem " + Idade + " anos de idade.";
        }
    }
}
