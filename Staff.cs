using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    [Serializable]
    public class Staff
    {
        private int staffNumber;
        private int staffPrice;

        public int StaffNumber { get => staffNumber; set => staffNumber = value; }
        public int StaffPrice { get => staffPrice; set => staffPrice = value; }

        public Staff(int staffNumber, int staffPrice)
        {
            this.StaffNumber = staffNumber;
            this.StaffPrice = staffPrice;
        }
    }
}
