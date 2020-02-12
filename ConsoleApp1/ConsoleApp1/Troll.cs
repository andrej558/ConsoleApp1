using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Troll : Enemy
    {
        public Troll()  : base(){
            this.health = 200;
        }

        public override void Attack()
        {
            Console.WriteLine("Damage done 50");
        }

        public override int getHealth()
        {
            return this.health;
        }
    }
}
