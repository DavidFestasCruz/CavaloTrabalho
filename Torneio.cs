using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    public class Torneio
    {
        private int equipas;
        private int participantes;
        private string pista;

        public Torneio(int equipas, int participantes, string pista)
        {
            this.equipas = equipas;
            this.participantes = participantes;
            this.pista = pista;
        }

        public int Equipas { get => equipas; set => equipas = value; }
        public int Participantes { get => participantes; set => participantes = value; }
        public string Pista { get => pista; set => pista = value; }
    }
}
