using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Sword : Weapon
    {
        public Sword()
        {
            damage = 20;
            dexterity = 5;
            power = 10;
            shieldAvailable = true;
            critChanсe = (int)(critChanсe + critChanсe * 0.35);
            critDamage = (int)(critDamage + critDamage * 1.5);
        }
    }
}
