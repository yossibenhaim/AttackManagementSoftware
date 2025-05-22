using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class IntelligenceDivision 
    {
        public List<ITerrorist> terrorists = new List<ITerrorist>();

        
        public void addedTheTerrorist(ITerrorist terrorist)
        {
            terrorists.Add(terrorist);
        }

        public void searchTerrorist(string name)
        {
            forach (ITerrorist terrorist in terrorists){

                if (terrorist.name == name)
                {
                    Console.WriteLine("the terrorist is !!!!");
                }
            }
        }

        ITerrorist SearchingForDangerousTerrorist()
        {
            return this.terrorists[0];
        }
    }
}
