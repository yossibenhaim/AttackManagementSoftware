using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class menu_attack 
    {
        private const string MainMenuText = @"
========= Terrorist Management System =========

[1]  Show all living terrorists
[2]  Show the terrorist with the most messages
[3]  Show the most dangerous terrorist
[4]  Show all attack tools and their status
[5]  Launch an attack
[6]  Exit the system

==============================================
Enter your choice:
";
        public int Menu()
        {
            Console.WriteLine(MainMenuText);

            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || (num < 1 || num > 7))
            {
                Console.WriteLine("Invalid input. Please press a number between 1 and 6..");
            }
            return num;
        }


        public async Task start_menu(Func<int> menu)
        {
            HttpClient client = new HttpClient();

            QueryToGemini qtg = new QueryToGemini(client);
            tolls allToll = new tolls();
            Video video = new Video();
            Weapons f16 = new Weapons("F16", "building", 1, 10);
            Weapons f15 = new Weapons("F15", "cave", 1, 18);
            Weapons tank = new Weapons("tank", "car", 20, 30);
            allToll.addedTool(f15);
            allToll.addedTool(f16);
            allToll.addedTool(tank);

            ListAllTerrorist allTerrorist = new ListAllTerrorist(qtg);
            var generateTask = allTerrorist.StartGeneratingTerroristsPeriodically(allTerrorist);
            Attack attack = new Attack(allToll);
            AllMessage allMessage = new AllMessage(allTerrorist);
            IDF idf = new IDF(allToll, allTerrorist, allMessage, attack);


            bool run = true;
            while (run)
            {

                    int num = menu();
                switch (num)
                {
                    case 1:
                        idf.printAllTerroristIsLife();
                        break;
                    case 2:
                        idf.PrintAllMessage();
                        break;
                    case 3:
                        idf.PrintTheMostDangerousTerrorist();
                        break;
                    case 4:
                        idf.PrintStatusToolsAttack();
                        break;
                    case 5:
                        idf.AttackAndPrint();
                        break;
                    case 6:
                        run = false;
                        break;
                }
            }

        }

    }
}
