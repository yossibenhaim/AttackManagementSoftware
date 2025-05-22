using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public Terrorist SearchingForDangerousTerrorist()
        {
            int low = 0;
            Terrorist lowTerrorist = this.terrorists.Terrorists[0];
            foreach (Terrorist terrorist in this.terrorists.Terrorists)
            {
                Console.WriteLine(terrorist.level_of_danger());
                if (terrorist.level_of_danger() >= low)
                {
                    lowTerrorist = terrorist;
                    low = terrorist.level_of_danger();
                }
                
            }
            return lowTerrorist;
        }
    }
}
