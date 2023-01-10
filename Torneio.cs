using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    internal class Torneio
    {
        private int equipas;
        private int participantes;
        private string pista;

        public int Equipas { get => equipas; set => equipas = value; }
        public int Participantes { get => participantes; set => participantes = value; }
        public string Pista { get => pista; set => pista = value; }
    }
}
