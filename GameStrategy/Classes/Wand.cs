using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Wand : Weapon
    {
        public Wand(int level)
        {
            NameWeapon = "Wand";
            Damage = 5;
            Mana = 5;
            Intelligence = 5;
            CritChanсe = 5;
            CritDamage = 3;
            if(level == 2) 
            {
                NameWeapon = "Enchanted wand";
                Intelligence += 5;
                Armor = 2;
            }
            if(level == 3)
            {
                NameWeapon = "Rare wand";
                MagicDamage += 5;
                MagicDefense += 8;
                Health -= 5;
                Damage -= 5;
            }
        }
    }
}