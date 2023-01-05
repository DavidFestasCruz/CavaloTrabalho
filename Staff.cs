using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    public class Staff
    {
        private string name;
        private string funcao;

        public Staff(string name, string funcao)
        {
            this.name = name;
            this.funcao = funcao;
        }

        public string Name { get => name; set => name = value; }
        public string Funcao { get => funcao; set => funcao = value; }
    }
}
