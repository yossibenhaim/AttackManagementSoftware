using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class Program
    {
        static void Main(string[] args)
        {
            a yossi = new a ("yossi",5);
            a chaim = new a("chain", 4);
            List<a> lista = new List<a> { yossi, chaim };
            c cc = new c(lista);
        }
    }
}
