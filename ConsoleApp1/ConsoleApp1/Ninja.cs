using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ninja : Enemy
    {
        public Ninja() : base(){
            this.health = 100;
        }

        public override void Attack()
        {
            Console.WriteLine("Damage done 35");
        }

        public override int getHealth()
        {
            return this.health;
        }
    }
}
