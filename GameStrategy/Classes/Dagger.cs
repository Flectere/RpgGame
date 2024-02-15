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
        public bool TwoHanded;
        public Dagger(bool twoHanded)
        {
            damage = 10;
            dexterity = 15;
            critChanсe = (int)(critChanсe + critChanсe * 0.6);
            critDamage = (int)(critDamage + critDamage * 0.7);
            shieldAvailable = false;
            TwoHanded = twoHanded;
        }
    }
}
