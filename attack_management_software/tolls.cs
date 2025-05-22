using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class tolls
    {
        public List<Weapons> Weapons = new List<Weapons>();

        public void addedTool(Weapons weapon)
        {
            this.Weapons.Add(weapon);
        }
    }
}
