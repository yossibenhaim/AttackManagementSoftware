using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class IntelligenceDivision 
    {
        public ListAllTerrorist terrorists;
        public AllMessage messages;
        public IntelligenceDivision(ListAllTerrorist allTerrorist, AllMessage allMessage)
        {
            this.terrorists = allTerrorist;
            this.messages = allMessage;
        }

        public void searchTerrorist(string name)
        {
            foreach(Terrorist terrorist in this.terrorists.list_of_terrorists)
            {
                if (terrorist.Name_of_terrorist == name)
                {
                    Console.WriteLine("The terrorist has been found.");
                }
            }
        }

        public Terrorist SearchingForDangerousTerrorist()
        {
            int hige = 0;
            Terrorist higeTerrorist = this.terrorists.list_of_terrorists[0];
            foreach (Terrorist terrorist in this.terrorists.list_of_terrorists)
            { 
                if (terrorist.level_of_danger() >= hige)
                {
                    if (terrorist.Status) 
                    {
                        higeTerrorist = terrorist;
                        hige = terrorist.level_of_danger();
                    }
                }

            }
            return higeTerrorist;
        }

        public void printAllTerroristIsLife()
        {
            Console.WriteLine("===== Living Terrorists =====");
            Console.WriteLine($"{"Name",-20} | {"Danger Rating",-5}");
            Console.WriteLine(new string('-', 32));

            foreach (Terrorist terrorist in terrorists.list_of_terrorists)
            {
                Console.WriteLine($"{terrorist.Name_of_terrorist,-20} | {terrorist.level_of_danger(),-5}");
            }

        }


    }
}
