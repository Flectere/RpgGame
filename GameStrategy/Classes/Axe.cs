using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Axe : Weapon
    {
        public Axe()
        {
            damage = 30;
            power = 30;
            critChanсe = (int)(critChanсe + critChanсe * 0.2);
            critDamage = (int)(critDamage + critDamage * 1.7);
        }
    }
}
