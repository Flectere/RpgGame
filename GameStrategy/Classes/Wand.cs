using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Wand : Weapon
    {
        public Wand(int level)
        {
            damage = 5;
            mana = 5;
            intelligence = 5;
            critChanсe = 5;
            critDamage = 3;
            if(level == 2) 
            {
                intelligence += 5;
                armor = 2;
            }
            if(level == 3)
            {
                magicDamage += 5;
                magicDefense += 8;
                health -= 5;
                damage -= 5;
            }
        }
    }
}
