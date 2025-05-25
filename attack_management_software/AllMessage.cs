using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class AllMessage
    {
        public List<IntelligenceMessages> messages = new List<IntelligenceMessages>();
        public ListAllTerrorist listAllTerrorist;

        Random random = new Random();

        public AllMessage(ListAllTerrorist listAllTerrorist)
        {
            this.listAllTerrorist = listAllTerrorist;
        }


        public string FindingName()
        {
            int num = random.Next(0, listAllTerrorist.list_of_terrorists.Count);
            return listAllTerrorist.list_of_terrorists[num].Name_of_terrorist;
        }

        public string FindingLocation()
        {
            string[] locations = { "home", "car", "outside", "building", "cave" };
            int num = random.Next(0, locations.Length);
            return locations[num];

        }

        public void CreateIntelligenceReport()
        {
            FindingName();
            FindingLocation();

        }

        public void CreateMessage()
        {
            IntelligenceMessages intelligenceMessages = new IntelligenceMessages(FindingName(), FindingLocation());
            AddMessage(intelligenceMessages);
            PringAllMassage();
        }
        public void AddMessage(IntelligenceMessages message)
        {
            this.messages.Add(message);
        }
        
        public void PringAllMassage()
        {
            foreach (IntelligenceMessages m in this.messages)
            {
                Console.WriteLine(m.name + " " + m.location);
            }
        }


    }

}
