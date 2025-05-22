using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class IntelligenceDivision 
    {
        public all terrorists;
        public IntelligenceDivision(all allTerrorist)
        {
            this.terrorists = allTerrorist;
        }

        public void searchTerrorist(string name)
        {
            foreach(Terrorist terrorist in this.terrorists.Terrorists)
            {
                if (terrorist.Name_of_terrorist == name)
                {
                    Console.WriteLine("The terrorist has been found.");
                }
            }
        }

    }
}
