using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class menu_attack
    {
        public int Menu()
        {
            Console.WriteLine("\r\n \r\n To display a terrorist with the most messages, press \"1\"." +
                " \r\n To display the Most Dangerous Terrorist, press \"2\"." +
                " \r\n To view attack tools and their status press \"3\"." +
                " \r\n To perform an attack, press \"4\"." +
                " \r\n To exit press \"5\".  ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }


        public void start_menu(Func<int> menu)
        {
            ListAllTerrorist terrorists = new ListAllTerrorist();
            terrorists.Terrorist_creator();
            tolls allToll = new tolls();
            Video video = new Video();
            Weapons f16 = new Weapons("F16", "building", 10, 10);
            Weapons f15 = new Weapons("F15", "cave", 15, 18);
            Weapons tank = new Weapons("tank", "car", 20, 30);
            allToll.addedTool(f15);
            allToll.addedTool(f16);
            allToll.addedTool(tank);

            IDF idf = new IDF(allToll, terrorists);

            bool run = true;
            while (run)
            {
                int num = menu();
                switch (num)
                {
                    case 1:
                        idf.print();
                        break;
                    case 2:
                        idf.Finding_the_Most_Dangerous_Terrorist();
                        break;
                    case 3:
                        foreach (Weapons tool in allToll.Weapons)
                        {
                            Console.WriteLine($"The {tool.name} vessel is designed for attack in {tool.purpose} and has {tool.countOfAattack} ammunition. And {tool.countOfGas} fuel.");
                        }
                        break;
                    case 4:
                        idf.attack.attack(idf.intelligence.SearchingForDangerousTerrorist());
                        break;
                    case 5:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;



                }
            }

        }

    }
}
