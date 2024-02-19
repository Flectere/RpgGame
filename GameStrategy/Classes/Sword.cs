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
            NameWeapon = "Sword";
            Damage = 20;
            Dexterity = 5;
            Power = 10;
            shieldAvailable = true;
            CritChanсe = 0.35;
            CritDamage = 1.5;
            if (level == 2) 
            {
                NameWeapon = "Enchanted sword";
                Damage = 30;
                Power = 20;
            }
            if (level == 3)
            {
                NameWeapon = "Rare sword";
                Damage = 30;
                Power = 20;
                Dexterity = 10;
                Intelligence = 3;
            }
        }
    }
}
