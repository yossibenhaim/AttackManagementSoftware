using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace attack_management_software
{
    internal class Weapons:IAttackTool
    {
        public string name { get; set; }
        public string purpose { get; set; }
        public int countOfAattack { get; set; }
        public int countOfGas { get; set; }

        public Weapons(string name, string purpose, int countOfAattack, int countOfGas)
        {
            this.name = name;
            this.purpose = purpose;
            this.countOfAattack = countOfAattack;
            this.countOfGas = countOfGas;
        }
        public void changeCountAttack()
        {
            countOfAattack--;
        }
        public void changeCountGas()
        {
            countOfGas -= 5;
        }


        
    }
}
