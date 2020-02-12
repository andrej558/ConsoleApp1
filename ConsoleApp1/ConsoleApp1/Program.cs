using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy a = new Ninja();
            Enemy b = new Troll();
            Console.WriteLine(a.getHealth());
            Console.WriteLine(b.getHealth());

            a.Attack();
            b.Attack();

        }
    }
}
