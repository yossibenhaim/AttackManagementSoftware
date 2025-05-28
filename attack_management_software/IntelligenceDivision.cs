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
        public ListAllTerrorist allTerrorist;
        public IntelligenceDivision(ListAllTerrorist AllTerrorist)
        {
            this.allTerrorist = AllTerrorist;
        }
        
        public Terrorist SearchingForDangerousTerrorist()
        {
            int hige = 0;
            Terrorist higeTerrorist = this.allTerrorist.list_of_terrorists[0];
            foreach (Terrorist terrorist in this.allTerrorist.list_of_terrorists)
            { 
                if (terrorist.level_of_danger() >= hige)
                {
                    if (terrorist.Status) 
                    {
                        higeTerrorist = terrorist;
                        hige = terrorist.level_of_danger();
                    }
                }

            }
            return higeTerrorist;
        }

        public List<Terrorist> returnAllTerroristIsLife()
        {
            List<Terrorist> terroristsIsLife = new List<Terrorist>();

            foreach (Terrorist terrorist in allTerrorist.list_of_terrorists)
            {   if (terrorist.Status)
                {
                    terroristsIsLife.Add(terrorist);

                }
            }
            return terroristsIsLife;
        }


    }
}
