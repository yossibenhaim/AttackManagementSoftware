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
        private IAttackTool weapons;
        private IInfomition infomition;
        private Attack attack;

        public IDF(IAttackTool attackTool, IInfomition infomition, Attack attack)
        {this.weapons = attackTool; this.infomition = infomition; this.attack = attack; }

    }
}
