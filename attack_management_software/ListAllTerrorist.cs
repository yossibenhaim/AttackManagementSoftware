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
            string[] prompts = {
                "תביא לי שם ערבי חדש ומקורי. תביא לי רק שם פרטי ומשפחה. ללא ניקוד או מילים נוספות. הכוונה היא תחזיר 2 מילים בלבד",
  "תביא שם ערבי שלא הזכרתי לפני כן.  תביא לי רק שם פרטי ומשפחה. ללא ניקוד או מילים נוספות.  הכוונה היא תחזיר 2 מילים בלבד",
  "תן שם ערבי שונה ממה שנתתי לך עד עכשיו.  תביא לי רק שם פרטי ומשפחה. ללא ניקוד או מילים נוספות.  הכוונה היא תחזיר 2 מילים בלבד"
}
;
            string prompt = prompts[_rnd.Next(prompts.Length)];
            string name = await this._qtg.queryToGemini(prompt);
            return name;
        }

        public async Task<string> creates_location()
        {
            string[] queries = new string[]
            {
    "אני מביא לי רשימה. תביא לי מילה אחת בלבד מתוך הרשימה הבאה [car, building, cave], וודא שהתשובה היא רק אחת מהמילים האלו, בלי שום מילים נוספות, בלי רווחים או ירידות שורה. תגוון בכל פעם מחדש.",
    "תבחר מילה אחת בלבד מהרשימה [building, cave, car]. התשובה חייבת להיות רק מהמילים האלו, בלי תוספות או מילים נוספות, ותחזיר רק את המילה עצמה ללא רווחים או שורות חדשות.",
    "מבקש מילה אחת בלבד מתוך [cave, car, building], וודא שהמילה היא רק מתוך הרשימה הזו, ללא תוספות או מילים אחרות. בבקשה תחזיר רק את המילה, בלי רווחים ובלי שורות חדשות, ותגוון בכל פעם.",
    "תן לי מילה אחת מתוך הרשימה [car, cave, building], וודא שהתשובה היא רק אחת מהמילים האלו, בלי רווחים או ירידות שורה, ותגוון את התשובה בכל פעם מחדש.",
    "בחר מילה אחת מתוך [building, car, cave], וודא שהתשובה היא רק מהמילים שבסוגריים, בלי תוספות, רווחים או שורות חדשות, ותגוון בכל פעם."
            };

            string query = queries[_rnd.Next(queries.Length)];
            string locasion = await this._qtg.queryToGemini(query);
            return locasion;
        }

        public async Task<int> creates_dark()
        {

            string[] queriesForNumber = new string[]
{
    "תגוון בבקשה. אל תחזיר מספר שהוחזר מקודם, תחזיר לי ספרה בין 1 ל-5 כולל. תחזיר רק את הספרה עצמה, בלי מילים, רווחים או ירידות שורה.",
    "תן לי ספרה אחת בין 1 ל-5, בלי חזרה על מספרים קודמים. תענה רק עם הספרה, בלי תוספות או רווחים, ובלי ירידת שורה.",
    "בחר מספר חדש בין 1 ל-5 שלא חזרת עליו לפני כן. תחזיר רק את הספרה, ללא מילים נוספות, רווחים או שורות חדשות.",
    "החזר ספרה אחת בטווח 1 עד 5, שלא הוחזרה בעבר. אין מילים, רווחים או שורות חדשות, רק הספרה עצמה.",
    "בבקשה, תגוון עם מספר בין 1 ל-5, שלא חזרת עליו לפני כן. תחזיר רק את הספרה, בלי תוספות, רווחים או ירידות שורה."
};

            string query = queriesForNumber[_rnd.Next(queriesForNumber.Length)];

            string num = await this._qtg.queryToGemini(query);

            return Convert.ToInt32(num);
        }

        public async Task<string> creates_type_of_weapon()
        {
           
            string[] queriesForWeapon = new string[]
            {
    "אני מביא לי רשימה. תביא לי מילה אחת בלבד מתוך הרשימה הבאה [knife, gun, M16, AK47]. תחזיר רק את המילה עצמה, בלי רווחים או ירידות שורה, ותגוון בכל פעם מחדש.",
    "תבחר מילה אחת מהרשימה [gun, AK47, knife, M16]. תענה רק עם המילה, בלי מילים נוספות, בלי רווחים ובלי שורות חדשות.",
    "מבקש מילה אחת בלבד מתוך [M16, knife, AK47, gun], ללא תוספות, רווחים או שורות חדשות. בבקשה תשנה כל פעם את המילה.",
    "תן לי מילה אחת מתוך הרשימה [AK47, M16, gun, knife], תענה רק עם המילה עצמה, בלי רווחים או קפיצות שורה, ותשנה כל פעם את התשובה.",
    "בחר מילה אחת מתוך [knife, M16, gun, AK47], תענה רק עם המילה, בלי רווחים או ירידת שורה, ותגוון בכל פעם."
            };


            string query = queriesForWeapon[_rnd.Next(queriesForWeapon.Length)];
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
        public async Task StartGeneratingTerroristsPeriodically(ListAllTerrorist allTerrorist)
        {
            while (true)
            {
                await Terrorist_creator();  // יוצרת 2 טרוריסטים, תשנה ב- Terrorist_creator למספר 3 במקום 2 אם רוצים
                Console.WriteLine("נוצרו טרוריסטים חדשים");
                await Task.Delay(TimeSpan.FromMinutes(1));  // המתנה של דקה
            }
        }

    }
}

