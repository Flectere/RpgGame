using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Wand : Weapon
    {
        public Wand()
        {
            damage = 5;
            mana = 5;
            intelligence = 5;
            critChanсe = 5;
            critDamage = critDamage * 3;
            shieldAvailable = false;
        }
    }
}
