using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{

    internal class IDF : IntelligenceDivision
    {

        public tolls allToll;
        public Attack attack;
        public AllMessage allMessage;

        public IDF(tolls tolls, ListAllTerrorist allTerrorist, AllMessage allMessage, Attack attack) : base(allTerrorist)
        {
            this.allToll = tolls;
            this.allMessage = allMessage;
            this.attack = attack;
        }

        public void printAllTerroristIsLife()
        {
            List<Terrorist> terrorists = returnAllTerroristIsLife();

            Console.WriteLine("===== Living Terrorists =====");
            Console.WriteLine($"{"Name",-20} | {"Danger Rating",-5}");
            Console.WriteLine(new string('-', 32));

            foreach (Terrorist terrorist in allTerrorist.list_of_terrorists)
            {
                Console.WriteLine($"{terrorist.Name_of_terrorist,-20} | {terrorist.level_of_danger(),-5}");
            }

        }
        public void PrintTheMostDangerousTerrorist()
        {
            Terrorist DangerousTerrorist = SearchingForDangerousTerrorist();
            Console.WriteLine("===== Most Dangerous Terrorist =====");
            Console.WriteLine($"Name         : {DangerousTerrorist.Name_of_terrorist}");
            Console.WriteLine($"Danger Level : {DangerousTerrorist.level_of_danger()}");
            attack.FindingSuitableAttackTool(DangerousTerrorist);
        }

        public void PrintAllMessage()
        {
            allMessage.CreateNewIntelligenceReport();
            List<IntelligenceMessages> messages =  allMessage.ReturnAllMassage();
            Console.WriteLine("===== Most Active Terrorist - Message Log =====");
            foreach (IntelligenceMessages m in messages)
            { Console.WriteLine($"Terrorist: {m.name,-20} | Location: {m.location,-15} | Date: {m.date}"); }
        }

        public void PrintStatusToolsAttack()
        {
            Console.WriteLine("===== Attack Tools Status =====");
            foreach (Weapons tool in allToll.Weapons)
            {
                Console.WriteLine($"Tool Name   : {tool.name}");
                Console.WriteLine($"Purpose     : {tool.purpose}");
                Console.WriteLine($"Ammunition  : {tool.countOfAattack}");
                Console.WriteLine($"Fuel        : {tool.countOfGas}");
                Console.WriteLine(new string('-', 35));
            }
        }
        public void AttackAndPrint()
        {
            Terrorist terrorisDangerous = SearchingForDangerousTerrorist();
            Weapons weapon = attack.FindingSuitableAttackTool(terrorisDangerous);
            if (weapon != null)
            {
                Console.WriteLine($"Location           : {terrorisDangerous.Terrorist_location}");
                Console.WriteLine($"Appropriate Weapon : {weapon.name}");
                Console.WriteLine("To perform the attack, press 1. To cancel, press 2.");

                int a;
                while (!int.TryParse(Console.ReadLine(), out a) || (a != 1 && a != 2))
                {
                    Console.WriteLine("Invalid input. Please press 1 to attack or 2 to cancel.");
                }

                switch (a)
                {
                    case 1:
                        terrorisDangerous.Status = false;
                        weapon.countOfAattack--;
                        weapon.countOfGas--;
                        Console.WriteLine($"The terrorist {terrorisDangerous.Name_of_terrorist} has been eliminated!");
                        break;

                    case 2:
                        Console.WriteLine("Attack cancelled.");
                        break;

                    default:
                        Console.WriteLine("Unexpected error: Invalid choice.");
                        break;
                }
            }

        }

    }

}
