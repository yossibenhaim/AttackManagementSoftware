using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class Terrorist
    {
        string Name_of_terrorist;
        string Terrorist_location;
        string Type_of_weapon;
        int Rank;
        bool Status_terrorist;

        Terrorist (string name, string location, string weapon, int rank, bool status)
        {
            this.Name_of_terrorist = name;
            this.Terrorist_location = location;
            this.Type_of_weapon= weapon;
            this.Rank = rank;
            this.Status_terrorist= status;
        }

          

        void status_change(bool new_status)
        {
            Status_terrorist = new_status;
        }


        void Change_weapons(string new_wapons) 
        {
            Type_of_weapon = new_wapons;
        }

        void Chenge_location(string new_location)
        {
            Terrorist_location = new_location;
        }

        int Dangerous_weapons() 
        {
            int Dangerous_weapons = 0;
            switch (Type_of_weapon)
            {
                case "knife":
                    Dangerous_weapons = 1;
                    break;
                case "gun":
                    Dangerous_weapons = 2;
                    break;
                case "M16":
                    Dangerous_weapons = 3;
                    break;
                case "AK47":
                    Dangerous_weapons = 3;
                    break;
            }
            return Dangerous_weapons; 
        }

        int level_of_danger(int rank, Func<int> Dangerous_weapons)
        {
            int weapons = Dangerous_weapons();
            int level = weapons * rank;

            return 0; 
        }
    }
}
