using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    internal class Pista : Torneio
    {
        private string tipo;
        private int recompensaPrimeiro;
        private int recompensaSegundo;
        private int recompensaTerceiro;

        public string Tipo { get => tipo; set => tipo = value; }
        public int RecompensaPrimeiro { get => recompensaPrimeiro; set => recompensaPrimeiro = value; }
        public int RecompensaSegundo { get => recompensaSegundo; set => recompensaSegundo = value; }
        public int RecompensaTerceiro { get => recompensaTerceiro; set => recompensaTerceiro = value; }
    }
}
