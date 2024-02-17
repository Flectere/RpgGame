using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Axe : Weapon
    {
        public Axe(int level)
        {
            damage = 30;
            power = 30;
            critChanсe = 0.2;
            critDamage = 1.7;
            if (level == 2)
            {
                dexterity = -10;
                power = 40;
            }
            else if (level == 3)
            {
                dexterity = -20;
                power = 40;
                critChanсe -= 2;
                critDamage = 2;
            }
        }
    }
}