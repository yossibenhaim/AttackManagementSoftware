using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{

    internal class IDF
    {
        //public IAttackTool weapons;
        public tolls allToll;
        public all allTerrorist;
        public Attack attack;

        public IDF(tolls tolls, all terrorist, Attack attack)
        {
            //this.weapons = attackTool;
            //this.infomition = infomition;
            this.allToll = tolls;
            this.allTerrorist = terrorist;
            this.attack = attack;
            Console.WriteLine("the tools is open");
            Console.WriteLine("the terrorists is open");
           
        }
        public void print()
        {
            foreach (Weapons weapon in allToll.Weapons)
            {
                Console.WriteLine(weapon.name);
            }

            foreach (Terrorist terrorist in allTerrorist.Terrorists)
            {
                Console.WriteLine(terrorist.Name_of_terrorist);
            }
        }
    }

}
