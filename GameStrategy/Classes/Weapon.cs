using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Weapon
    {
        public int power;
        public int intelligence;
        public int dexterity;
        public int vitality;
        public int health;
        public int mana;
        public int damage;
        public int armor;
        public int magicDamage;
        public int magicDefense;
        public double critChanсe;
        public double critDamage;
        public bool shieldAvailable = true;
        public bool twoWeapon = false;
    }
}