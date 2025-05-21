using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal interface IAttackTool
    {
        string name { get; set; }
        string purpose { get; set; }
        int countOfAattack { get; set; }
        int countOfGas { get; set; }

        void IAttackTool(string name, string purpose, int countOfAattack, int countOfGas);

        void changeCountAttack();
        void changeCountGas();

    }
}
