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

            Weapons f16 = new Weapons("F16", "Building", 15, 90);
            Weapons f15 = new Weapons("F15", "Building", 10, 50);
            Weapons tank = new Weapons("tank", "knife", 9, 200);
            allToll.addedTool(f15);
            allToll.addedTool(f16);
            allToll.addedTool(tank);

            IDF idf = new IDF(allToll, terrorists);
            idf.print();

        }
    }
}
