using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class ListAllTerrorist
    {
        List<Terrorist> list_of_terrorists = new List<Terrorist> { };

        
        
        public string creates_names()
        {
            string[] AllTerrorist = { "אחמד", "מחמד", "עלי", "עומר", "אוסאמה",
    "חסן", "חוסיין", "אברהים", "יוסף", "עבדאללה",
    "פאטמה", "חנאן", "ראנא", "ליילה", "סאלח",
    "סלים", "עיאד", "עאמר", "עאישה", "מרים",
    "זינב", "דינה", "רנא", "חאלד", "מונא",
    "כרים", "נור", "סמיר", "רשא", "אמינה"};
            Random rnd = new Random();
            int num = rnd.Next (0, AllTerrorist.Length-1);
            string name = AllTerrorist[num];
            return name;
        }

        public string creates_location()
        {
            string[] locations = { "home", "car", "outside", "building", "cave"};
            Random rand = new Random();
            int num = rand.Next (0, locations.Length-1);  
            string location = locations[num];
            return location;
        }

        public int creates_dark()
        {
            Random rand = new Random();
            int num = rand.Next(1, 6);
            return num;
        }

        public string creates_type_of_weapon()
        {
            string[] weapons = { "knife", "gun", "M16", "AK47"};
            Random rand = new Random();
            int num = rand.Next(0, weapons.Length - 1);
            string type = weapons[num];
            return type;
        }

        public void Terrorist_creator()
        {
            for (int i = 0; i < 11; i++) 
            {
                Terrorist terrorist = new Terrorist(creates_names(), creates_location(), creates_type_of_weapon(), creates_dark(), true);
                list_of_terrorists.Add(terrorist);
            }
        }
    }
}

