using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace GameStrategy.Classes
{
    [BsonKnownTypes(typeof(Warrior), typeof(Rogue),  typeof(Wizard))]
    public class Hero
    {
        protected string _name;
        protected Weapon _weapon;
        protected int _levelPoints;
        protected int _level;
        protected int _power;
        protected int _intelligence;
        protected int _dexterity;
        protected int _vitality;
        private int _starPoints;
        private int _health;
        private int _mana;
        private int _damage;
        private int _armor;
        private int _magicDamage;
        private int _magicDefense;
        private double _critChanсe;
        private double _critDamage;
        int expirienceToNextLevel = 1000;

        /// <summary>
        /// Логика для вычисления нужного количества опыта для следующего уровня
        /// </summary>
        void CalculateExpirience()
        {
            for (int i = Level + 1; i > 0; i--)
            {
                expirienceToNextLevel += 1000 * i;
            }
        }

        public ObjectId _id;
        public string Name { get { return _name; } set { _name = value; } }
        public int LevelPoints { get { return _levelPoints; }
            set
            {
                if (value >= expirienceToNextLevel)
                {
                    Level++;
                    _levelPoints = 0;
                    return;
                }
               _levelPoints = value; 
            }
        }
        public int Level { get { return _level; } 
            set 
            {
                //MessageBox.Show($"v{value} l{_level}");
                _level = value;
                if (_level == 0 )
                {
                    expirienceToNextLevel = 1000;
                    return;
                }
                if (value >= 99)
                {
                    _level = 99;
                }
                expirienceToNextLevel = 0;
                CalculateExpirience();
                StarPoints += 5;
            } 
        }
        
        public virtual int Power { get { return _power; } set { _power = value + _weapon.power; } }
        public virtual int Intelligence { get { return _intelligence; } set { _intelligence = value + _weapon.intelligence; } }
        public virtual int Dexterity { get { return _dexterity; } set { _dexterity = value + _weapon.dexterity; } }
        public virtual int Vitality { get { return _vitality; } set { _vitality = value + _weapon.vitality; } }
        public int StarPoints { get { return _starPoints; } 
            set { 
                    if (value >= 0)
                    {
                        _starPoints = value;
                    }
                } 
        }

        public int Health { get { return _health; } set { _health = value + Weapon.health; } }
        public int Mana { get { return _mana; } set { _mana = value + Weapon.mana; } }
        public int Damage { get { return _damage; } set { _damage = value + Weapon.damage; } }
        public int Armor { get { return _armor; } set { _armor = value + Weapon.armor; } }
        public int MagicDamage { get { return _magicDamage; } set { _magicDamage = value + Weapon.magicDamage; } }
        public int MagicDefense { get { return _magicDefense; } set { _magicDefense = value + Weapon.magicDefense; } }
        public double CritChance { get {
                if (Weapon is Wand)
                    CritChance = (int)(Weapon.critChanсe);
                else
                    CritChance = (int)(_dexterity * 0.2 + _critChanсe * Weapon.critChanсe);
                return _critChanсe;
            } 
            set { _critChanсe = value; } }
        public double CritDamage { get 
            {
                if (Weapon is Wand)
                    CritDamage = Weapon.critDamage;
                else
                    CritDamage = _dexterity * 0.1 + _critDamage * Weapon.critDamage;
                return _critDamage;
            } 
            set { _critDamage = value; } }
        public Weapon Weapon
        {
            get { return _weapon; }
            set
            {
                Power -= _weapon.power;
                Dexterity -= _weapon.dexterity;
                Vitality -= _weapon.vitality;
                Intelligence -= _weapon.intelligence;

                _weapon = value;

                Power += _weapon.power;
                Dexterity += _weapon.dexterity;
                Vitality += _weapon.vitality;
                Intelligence += _weapon.intelligence;
            }
        }

        public Hero(string name)
        {
            _name = name;
            _weapon = new Hand();
        }
    }
}
