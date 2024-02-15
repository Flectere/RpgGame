using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    internal class Weapon
    {
        protected int power;
        protected int intelligence = 0;
        protected int dexterity = 0;
        protected int vitality = 0;
        protected int health = 0;
        protected int mana = 0;
        protected int damage = 0;
        protected int armor = 0;
        protected int magicDamage = 0;
        protected int magicDefense = 0;
        protected int critChanсe = 0;
        protected int critDamage = 0;
        protected bool shieldAvailable = false;
        public Weapon(int power, int intelligence, int dexterity, int vitality, int health,
                      int mana, int damage, int armor, int magicDamage, int magicDefense,
                      int critChance, int critDamage, bool shieldAvailable)
        {
            this.power = power;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.vitality = vitality;
            this.health = health;
            this.mana = mana;
            this.damage = damage;
            this.armor = armor;
            this.magicDamage = magicDamage;
            this.magicDefense = magicDefense;
            this.critChanсe = critChance;
            this.critDamage = critDamage;
            this.shieldAvailable = shieldAvailable;
        }
    }
}