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

        private QueryToGemini _qtg;

        public ListAllTerrorist(QueryToGemini qtg)
        {
            this._qtg = qtg;
        }

        public async Task<string> creates_names()
        {
            string query = "תביא לי שם של ערבי. תביא שם שעדיין לא נתת לי, תביא לי רק את השם ללא מילים נוספות";
            string name = await this._qtg.queryToGemini(query);


//            string[] AllTerrorist = {"Ahmad", "Muhammad", "Ali", "Omar", "Osama",
//"Hassan", "Hussein", "Ibrahim", "Yousef", "Abdullah",
//"Fatma", "Hanan", "Rana", "Layla", "Saleh",
//"Salim", "Eyad", "Amer", "Aisha", "Mariam",
//"Zainab", "Dina", "Rana", "Khaled", "Mona",
//"Kareem", "Noor", "Samir", "Rasha", "Amina"
//};

//            int num = _rnd.Next (0, AllTerrorist.Length);
//            string name = AllTerrorist[num];
            return name;
        }

        public async Task<string> creates_location()
        {
            //string[] locations = { "car", "building", "cave"};
            //int num = _rnd.Next (0, locations.Length);  
            //string location = locations[num];

            string query = $"אני מביא לי רשימה. תביא לי מילה אחת מתוכה. תחזיר מילה אחת בלבד [car, building, cave]שאתה מחזיר אל תיתן ירידת שורה, תגוון מפעמים קודמות.";
            string locasion = await this._qtg.queryToGemini(query);
            return locasion;
        }

        public async Task<int> creates_dark()
        {
            //int num = _rnd.Next(1, 6);
            string query = "תגוון בבקשה. אל תחזיר מספר שהוחזר מקודם , תחזיר לי ספרה בין 1 ל 5 כולל. תחזיר רק את הספרה ללא שום מילים או רווחים שאתה מחזיר אל תיתן ירידת שורה";
            string num = await this._qtg.queryToGemini(query);

            return Convert.ToInt32(num);
        }

        public async Task<string> creates_type_of_weapon()
        {
            //string[] weapons = { "knife", "gun", "M16", "AK47"};
            //int num = _rnd.Next(0, weapons.Length );
            //string type = weapons[num];
            //return type;

            string query = $"אני מביא לי רשימה. תביא לי מילה אחת מתוכה. תחזיר מילה אחת בלבד [knife, gun, M16, AK47] שאתה מחזיר אל תיתן ירידת שורה";
            string type = await this._qtg.queryToGemini(query);
            return type;
        }

        public async Task Terrorist_creator()
        {
            for (int i = 0; i < 2; i++) 
            {
                Terrorist terrorist = new Terrorist(await creates_names(), await creates_location(), await creates_type_of_weapon(),await creates_dark());
                list_of_terrorists.Add(terrorist);
            }
        }
    }
}

