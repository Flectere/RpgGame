using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Mace : Weapon
    {
        public Mace(int level)
        {
            damage = 30;
            power = 20;
            health = 5;
            critChanсe = 0.1;
            critDamage = 2.5;
            if (level == 2)
            {
                dexterity -= 10;
                power = 25;
            }
            if (level == 3)
            {
                dexterity -= 5;
                power = 25;
                damage = 50;
                intelligence -= 5;
            }
        }
    }
}
