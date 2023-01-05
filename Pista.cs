using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    public class Pista : Torneio
    {
        private string tipo;
        private int recompensa;
        public Pista(int equipas, int participantes, string pista, string tipo, int recompensa) : base(equipas, participantes, pista)
        {
            this.tipo = tipo;
            this.recompensa = recompensa;
        }
    }
}
