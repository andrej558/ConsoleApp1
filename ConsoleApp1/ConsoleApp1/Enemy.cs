using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Enemy
    {
        protected int health;
        public Enemy() {
            
        }
        public abstract void Attack();
        public abstract int getHealth();
    }
}
