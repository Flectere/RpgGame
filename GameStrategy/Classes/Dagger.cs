using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Serializers;

namespace GameStrategy.Classes
{
    public class Dagger : Weapon
    {
        public Dagger(int level)
        {
            damage = 10;
            dexterity = 15;
            critChanсe = 0.6;
            critDamage = 0.7;
            shieldAvailable = false;
            if (level == 2)
            {
                critChanсe = 0.7;
                critDamage = 0.8;
            }
            else if (level == 3)
            {
                damage = -5;
                shieldAvailable = true;
                dexterity = -10;
                vitality = 10;
            }
        }
    }
}
