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
        public ListAllTerrorist allTerrorist;
        public Attack attack;
        public IntelligenceDivision intelligence;

        public IDF(tolls tolls, ListAllTerrorist terrorist)
        {
            this.allToll = tolls;
            this.allTerrorist = terrorist;
            this.intelligence = new IntelligenceDivision(allTerrorist);
            this.attack = new Attack(allTerrorist, allToll);
        }

        public void Finding_the_Most_Dangerous_Terrorist()
        {
            Terrorist DangerousTerrorist = intelligence.SearchingForDangerousTerrorist();
            Console.WriteLine("The most dangerous terrorist is: " + DangerousTerrorist.Name_of_terrorist + "It has a danger level of:" + DangerousTerrorist.level_of_danger());

        }

        public void print()
        {
            foreach (Weapons weapon in allToll.Weapons)
            {
                Console.WriteLine(weapon.name + "  this is a woepons");
            }

            foreach (Terrorist terrorist in allTerrorist.list_of_terrorists)
            {
                Console.WriteLine(terrorist.Name_of_terrorist + $"  this is terrorist");
            }
            
            attack.FindingSuitableAttackTool(intelligence.SearchingForDangerousTerrorist());
        }
    }

}
