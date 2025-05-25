using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class ListAllTerrorist
    {
        public List <Terrorist> list_of_terrorists = new List<Terrorist> { };
        private Random _rnd = new Random();



        public string creates_names()
        {
            string[] AllTerrorist = {"Ahmad", "Muhammad", "Ali", "Omar", "Osama",
"Hassan", "Hussein", "Ibrahim", "Yousef", "Abdullah",
"Fatma", "Hanan", "Rana", "Layla", "Saleh",
"Salim", "Eyad", "Amer", "Aisha", "Mariam",
"Zainab", "Dina", "Rana", "Khaled", "Mona",
"Kareem", "Noor", "Samir", "Rasha", "Amina"
};

            int num = _rnd.Next (0, AllTerrorist.Length);
            string name = AllTerrorist[num];
            return name;
        }

        public string creates_location()
        {
            string[] locations = { "home", "car", "outside", "building", "cave"};
            int num = _rnd.Next (0, locations.Length-1);  
            string location = locations[num];
            return location;
        }

        public int creates_dark()
        {
            int num = _rnd.Next(1, 6);
            return num;
        }

        public string creates_type_of_weapon()
        {
            string[] weapons = { "knife", "gun", "M16", "AK47"};
            int num = _rnd.Next(0, weapons.Length - 1);
            string type = weapons[num];
            return type;
        }

        public void Terrorist_creator()
        {
            for (int i = 0; i < 11; i++) 
            {
                Terrorist terrorist = new Terrorist(creates_names(), creates_location(), creates_type_of_weapon(), creates_dark());
                list_of_terrorists.Add(terrorist);
            }
        }
    }
}

