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
        tolls tolls;
        public Attack(tolls tolls)
        {
            this.tolls = tolls;
        }

        //public Weapons FindingSuitableAttackTool2(Terrorist terrorist)
        //{
        //    foreach (Weapons weapon in this.tolls.Weapons)
        //    { if (weapon.purpose == terrorist.Terrorist_location)
        //        { return weapon; }
        //    } return null;
        //}


        public Weapons FindingSuitableAttackTool(Terrorist terrorist)
        {
            foreach (Weapons weapon in this.tolls.Weapons)
            {
                if (weapon.purpose == terrorist.Terrorist_location)
                {
                    if ((weapon.countOfGas > 5) && (weapon.countOfAattack > 1)) {return weapon; }
                    
                    else if (weapon.countOfGas > 5) { Console.WriteLine($"The appropriate tool is {weapon.name} but you don't have enough ammunition for the attack. You have {weapon.countOfAattack} bombs."); }
                    if (weapon.countOfAattack < 1) { Console.WriteLine($"The appropriate tool is {weapon.name} but you don't have enough fuel for the attack. You have {weapon.countOfGas} liters of fuel."); }
                }
            }return null;
        }




    }
}







