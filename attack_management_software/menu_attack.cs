using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class menu_attack
    {
        public int Menu()
        {
            Console.WriteLine(" To display a terrorist with the most messages, press \"1\", \r\n To display a terrorist by level of danger, press \"2\", \r\n To view attack tools and their status press \"3\",\r\n To exit press \"4\".  ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }


        public void start_menu(Func<int> menu)
        {
            
            bool run = true;
            while (run) 
            {
                int num = menu();
                switch (num)
            {
                case 1:
                    Console.WriteLine("sd");
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    run = false;
                    break;

            }
            }
            
        }

    }
}
