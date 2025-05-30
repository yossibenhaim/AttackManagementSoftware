﻿using System;
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
        public ListAllTerrorist allTerrorist;

        Random random = new Random();

        public AllMessage(ListAllTerrorist allTerrorist)
        {
            this.allTerrorist = allTerrorist;
        }
        public string FindingName()
        {
            int num = random.Next(0, allTerrorist.list_of_terrorists.Count);
            return allTerrorist.list_of_terrorists[num].Name_of_terrorist;
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

        public void CreateNewIntelligenceReport()
        {
            string correntTime = DateTime.Now.ToString();
            IntelligenceMessages intelligenceMessages = new IntelligenceMessages(FindingName(), FindingLocation(), correntTime);
            AddMessage(intelligenceMessages);
        }
        public void AddMessage(IntelligenceMessages message)
        { this.messages.Add(message); }
        
        public List<IntelligenceMessages> ReturnAllMassage()
        {
            return messages;
        }


    }

}
