using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    static class VendedorCavalos
    {
        public static Cavalo getCavalo(string EscolhaCavalo, Equipa equipa)
        {
            Cavalo Basico = new Cavalo("Fraco", 2, 2, 10, 250);
            Cavalo Intermedio = new Cavalo("Medio", 10, 10, 10, 1500);
            Cavalo Forte = new Cavalo("Forte", 18, 18, 10, 3000);

            if (EscolhaCavalo == "Basico" && equipa.Dinheiro >= 250)
            {
                equipa.Dinheiro -= 250;
                return Basico;
            }
            else if (EscolhaCavalo == "Intermedio" && equipa.Dinheiro >= 1500)
            {
                equipa.Dinheiro -= 1500;
                return Intermedio;
            }
            else if (EscolhaCavalo == "Forte" && equipa.Dinheiro >= 3000)
            {
                equipa.Dinheiro -= 3000;
                return Forte;
            }
            else
            {
                return null;
            }

        }
    }
}
