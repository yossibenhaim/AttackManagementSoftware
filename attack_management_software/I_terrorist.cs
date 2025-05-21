using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal interface ITerrorist
    {
         string Name_of_terrorist {  set; }
         string Type_of_weapon { set; }
         int Rank { set;}
         bool Status_terrorist { set; }



        void status_change(bool new_status);


        void Change_weapons();

        int Dangerous_weapons();

        int level_of_danger(int rank, Func<int> Dangerous_weapons);
        


    }
}
