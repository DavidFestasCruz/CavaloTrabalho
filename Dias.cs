using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    public class Dias
    {
        public int dia;

        public Dias(int dia)
        {
            this.dia = dia;
        }
        public int diaHoje()
        {
            this.dia = this.dia + 1;
            return this.dia;
        }
    }

}
