using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Sword : Weapon
    {
        public Sword(int level)
        {
            damage = 20;
            dexterity = 5;
            power = 10;
            shieldAvailable = true;
            critChanсe = 0.35;
            critDamage = 1.5;
            if (level == 2) 
            {
                damage = 30;
                //доделать
            }
        }
    }
}
