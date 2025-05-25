using attack_management_software;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{

    internal class Program
    {
        static void Main(string[] args)
        {

            menu_attack mmenu = new menu_attack();
            mmenu.start_menu(mmenu.Menu);
            ListAllTerrorist terrorists = new ListAllTerrorist();
            terrorists.Terrorist_creator();

            tolls allToll = new tolls();

            

            menu_attack mmenu = new menu_attack();
            mmenu.start_menu(mmenu.Menu);

        }
    }
}
