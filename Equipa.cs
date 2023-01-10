using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    internal class Equipa
    {
        private string nome;
        private Cavalo cavalo;
        private string galgo;
        private int dinheiro;
        private int staff;

        public Equipa(string nome, string galgo, int dinheiro, int staff)
        {
            this.nome = nome;
            this.galgo = galgo;
            this.dinheiro = dinheiro;
            this.staff = staff;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Galgo { get => galgo; set => galgo = value; }
        public int Dinheiro { get => dinheiro; set => dinheiro = value; }
        public int Staff { get => staff; set => staff = value; }
        internal Cavalo Cavalo { get => cavalo; set => cavalo = value; }
    }
}
