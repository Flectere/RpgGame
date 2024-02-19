using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Mace : Weapon
    {
        public Mace(int level)
        {
            NameWeapon = "Mace";
            Damage = 30;
            Power = 20;
            Health = 5;
            CritChanсe = 0.1;
            CritDamage = 2.5;
            if (level == 2)
            {
                NameWeapon = "Enchanted mace";
                Dexterity -= 10;
                Power = 25;
            }
            if (level == 3)
            {
                NameWeapon = "Rare mace";
                Dexterity -= 5;
                Power = 25;
                Damage = 50;
                Intelligence -= 5;
            }
        }
    }
}
