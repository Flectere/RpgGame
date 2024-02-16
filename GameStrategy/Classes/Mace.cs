using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Mace : Weapon
    {
        public Mace()
        {
            damage = 30;
            power = 20;
            health = 5;
            critChanсe = (int)(critChanсe + critChanсe * 0.1);
            critDamage = (int)(critDamage + critDamage * 2.5);
        }
    }
}
