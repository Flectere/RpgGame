using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Axe : Weapon
    {
        public Axe(int level)
        {
            NameWeapon = "Axe";
            Damage = 30;
            Power = 30;
            CritChanсe = 0.2;
            CritDamage = 1.7;
            if (level == 2)
            {
                NameWeapon = "Enchanted axe";
                Dexterity = -10;
                Power = 40;
            }
            else if (level == 3)
            {
                NameWeapon = "Rare axe";
                Dexterity = -20;
                Power = 40;
                CritChanсe -= 2;
                CritDamage = 2;
            }
        }
    }
}