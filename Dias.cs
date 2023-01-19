using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    [Serializable]
    public static class Dias
    {
        public static int dia = 0;

        public static int nextDay()
        {
            dia = dia + 1;
            return dia;
        }

        public static string dailyEvent(Cavalo cavalo)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 3);

            switch (random)
            {
                case 1:
                    cavalo.Velocidade = cavalo.Velocidade + 2;
                    return "O cavalo sente-se energético e começou a correr sozinho na pista de treino. +2 de Velocidade!";

                case 2:
                    Status Status = Status.doente;
                    return "O cavalo adoeceu.";

                    default:
                    return "Nothing happened";
            }
        }
    }
}
