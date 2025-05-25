using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Weapons FindingSuitableAttackTool2(Terrorist terrorist)
        {
            foreach (Weapons weapon in this.tolls.Weapons)
            {
                if (weapon.purpose == terrorist.Terrorist_location)
                {
                    return weapon;
                }
            }
            return tolls.Weapons[0];
        }


        public void FindingSuitableAttackTool(Terrorist terrorist)
        {
            bool check = false;
            foreach (Weapons weapon in this.tolls.Weapons)
            {
                if (weapon.purpose == terrorist.Terrorist_location)
                {
                    if ((weapon.countOfGas > 0) && (weapon.countOfAattack > 0))
                    {
                        check = true;
                        Console.WriteLine($"the locision is {terrorist.Terrorist_location}");
                        Console.WriteLine($"the tool of appropriate is {weapon.name}");
                    }    
                }
            }
            if (!check)
            {
                Console.WriteLine("You don't have a suitable tool available for the attack.");
            }
        }



        public void attack(Terrorist terrorist)
        {

            Weapons weapon = FindingSuitableAttackTool2(terrorist);
            Console.WriteLine("If you want to perform the attack, press 1. Otherwise, press 2.");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    terrorist.Status = false;
                    weapon.countOfAattack--;
                    weapon.countOfGas--;
                    Console.WriteLine($"The terrorist {terrorist.Name_of_terrorist} has been eliminated!!");
                    break;

                case 2:
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            
        }

    }
}







