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

        public IDF(tolls tolls)
        {
            //this.weapons = attackTool;
            //this.infomition = infomition;
            this.allToll = tolls;
            Console.WriteLine("the terrorist is open");
           
        }
        public void print()
        {
            foreach (Weapons weapon in allToll.Weapons)
            {
                Console.WriteLine(weapon.name);
            }
        }
    }

}
