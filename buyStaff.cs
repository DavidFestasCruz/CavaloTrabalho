using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    [Serializable]
    static class buyStaff
    {
        public static Staff getStaff(string comprarStaff)
        {
            Staff staffTeam = new Staff(1,10);
         
            Console.WriteLine("Quer comprar um membro de staff por " + staffTeam.StaffPrice + " moedas?");
            if (comprarStaff == "S")
            {
                staffTeam.StaffNumber = staffTeam.StaffNumber + 1;
                staffTeam.StaffPrice = staffTeam.StaffPrice + 1;
                Console.WriteLine("A tua equipa possui " + staffTeam.StaffNumber + " membros de staff.");
                return staffTeam;
            }
            else if (comprarStaff == "N")
            {
                Console.WriteLine("A tua equipa possui " + staffTeam.StaffNumber + " membros de staff.");
                return staffTeam;
            }
            else
            {
                Console.WriteLine("A tua equipa possui " + staffTeam.StaffNumber + " membros de staff.");
                return staffTeam;
            }
            

        }
    }
}
