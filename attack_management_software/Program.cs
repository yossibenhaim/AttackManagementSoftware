using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{

    internal class IDF
    {
        IAttackTool attack;
        IInfomition Infomition;
        public IDF(IAttackTool attackTool, IInfomition infomition)
        {
            attack = attackTool; Infomition = infomition;
        }


    }


    internal class dataHmas
    {
        public List<a> list = new List<a>();
    
        public void add(a item)
        {
            list.Add(item);
        }

        public a returnItem(string name)
        {
            foreach (a i in list)
            {
                if (i._name == name)
                {
                    return i;
                }
            }
            Console.WriteLine("you heve a problem!");
            return list[0];
        }
    
    
    }





    internal class a
    {
        public string _name = "";
        public int _count = 0;

        public a (string name, int count)
        {
            _name = name;
            _count = count;
        }
        public void strike()
        { _count--; }  
    }
    
    internal class b
    {
        public string _name = "chaim";
        private string _pleace = "dauad";
        public int _count = 5;
        public void strike()
        { _count--; }  
        public void changePleace(string pleace)
        { _pleace = pleace; }
    }

    internal class c
    {
        private List<a> bb = new List<a>();

        public c (List<a> listb)
        {
            bb = listb;
            int sum = 0;
            string name = "";

            foreach (a n in bb)
            {
                if (n._count >= sum)
                {
                    sum = n._count;
                    name = n._name;
                } 

            }
            Console.WriteLine($"sum is :{sum} and name is :{name}");
        }
    }

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
