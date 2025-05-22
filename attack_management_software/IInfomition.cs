using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal interface IInfomition
    {
        List <ListAllTerrorist> terrorists { get; set; }

        void searchTerrorist(string name);

        void SearchingForDangerousTerrorist();
    }
}
