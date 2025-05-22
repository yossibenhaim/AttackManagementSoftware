using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class Attack
    {
        ListAllTerrorist terrorists;
        tolls tolls;
        public Attack(ListAllTerrorist terrorists, tolls tolls)
        {
            this.terrorists = terrorists;
            this.tolls = tolls;
        }

        public void FindingSuitableAttackTool(Terrorist terrorist)
        {
            foreach (Weapons weapon in this.tolls.Weapons)
            {
                if (weapon.purpose == terrorist.Terrorist_location)
                {
                    Console.WriteLine($"the locision is {terrorist.Terrorist_location}");

                    Console.WriteLine($"the tool of appropriate is {weapon.name}");
                    break;

                }

            }
        }
    }
}
