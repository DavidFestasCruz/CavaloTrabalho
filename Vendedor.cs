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
            Cavalo Basico = new Cavalo("Fraco",250, 2, 2, 30);
            Cavalo Intermedio = new Cavalo("Medio", 1500, 10, 10, 20);
            Cavalo Forte = new Cavalo("Forte", 3000, 18, 18, 10);

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
                if (EscolhaCavalo != "Basico" && EscolhaCavalo != "Intermedio" && EscolhaCavalo != "Forte")
                {
                    Console.WriteLine("Escolha não válida");
                    return null;
                }
                else
                {
                    Console.WriteLine("Não tem dinheiro para esse cavalo");
                    return null;
                }
            }

        }
    }
}
