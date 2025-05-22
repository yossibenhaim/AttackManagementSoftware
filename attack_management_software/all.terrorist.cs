using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class all
    { 
        public List<Terrorist> Terrorists = new List<Terrorist>();

        public void addedTerrorist(Terrorist terrorist)
        {
            this.Terrorists.Add(terrorist);
        }
    }
}
