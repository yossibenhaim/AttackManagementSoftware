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
            Console.WriteLine(@"
========= Terrorist Management System =========

[1]  Show all living terrorists
[2]  Show the terrorist with the most messages
[3]  Show the most dangerous terrorist
[4]  Show all attack tools and their status
[5]  Launch an attack
[6]  Exit the system

==============================================
Enter your choice:
");

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
                        idf.intelligence.printAllTerroristIsLife();
                        break;
                    case 2:
                        idf.print();
                        break;
                    case 3:
                        idf.Finding_the_Most_Dangerous_Terrorist();
                        break;
                    case 4:
                        Console.WriteLine("===== Attack Tools Status =====");

                        foreach (Weapons tool in allToll.Weapons)
                        {
                            Console.WriteLine($"Tool Name   : {tool.name}");
                            Console.WriteLine($"Purpose     : {tool.purpose}");
                            Console.WriteLine($"Ammunition  : {tool.countOfAattack}");
                            Console.WriteLine($"Fuel        : {tool.countOfGas}");
                            Console.WriteLine(new string('-', 35));
                        }
                        break;
                    case 5:
                        idf.attack.attack(idf.intelligence.SearchingForDangerousTerrorist());
                        break;
                    case 6:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;



                }
            }

        }

    }
}
