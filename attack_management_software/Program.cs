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

            tolls allToll = new tolls();
            all terrorists = new all();
            Weapons f16 = new Weapons("F16", "Building", 15, 90);
            Weapons f15 = new Weapons("F15", "Building", 10, 50);
            Weapons tank = new Weapons("tank", "Houses", 9, 200);
            allToll.addedTool(f15);
            allToll.addedTool(f16);
            allToll.addedTool(tank);

            Terrorist mochmed = new Terrorist("mochmed","home", "knife", 5,true);
            Terrorist mochmed1 = new Terrorist("mochmed1","sxb", "knife", 3,true);
            Terrorist mochmed2 = new Terrorist("mochmed2","sxb", "knife", 2,true);
            Terrorist mochmed3 = new Terrorist("mochmed3","sxb", "knife", 1,true);

            terrorists.addedTerrorist(mochmed);
            terrorists.addedTerrorist(mochmed1);
            terrorists.addedTerrorist(mochmed2);
            terrorists.addedTerrorist(mochmed3);

            IDF idf = new IDF(allToll,terrorists);
            idf.print();

        }
    }
}
