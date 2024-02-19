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
            NameWeapon = "Dagger";
            Damage = 10;
            Dexterity = 15;
            CritChanсe = 0.6;
            CritDamage = 0.7;
            shieldAvailable = false;
            if (level == 2)
            {
                NameWeapon = "Enchanted dagger";
                CritChanсe = 0.7;
                CritDamage = 0.8;
            }
            else if (level == 3)
            {
                NameWeapon = "Rare dagger";
                Damage = 5;
                shieldAvailable = true;
                Dexterity = 5;
                Vitality = 10;
            }
        }
    }
}
