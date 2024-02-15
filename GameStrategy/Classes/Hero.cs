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
        private int _critChanсe;
        private int _critDamage;
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
        public virtual int Power { get { return _power; } set { _power = value; } }
        public virtual int Intelligence { get { return _intelligence; } set { _intelligence = value; } }
        public virtual int Dexterity { get { return _dexterity; } set { _dexterity = value; } }
        public virtual int Vitality { get { return _vitality; } set { _vitality = value; } }
        public int StarPoints { get { return _starPoints; } 
            set { 
                    if (value >= 0)
                    {
                        _starPoints = value;
                    }
                } 
        }
        public int Health { get { return _health; } set { _health = value; } }
        public int Mana { get { return _mana; } set { _mana = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int MagicDamage { get { return _magicDamage; } set { _magicDamage = value; } }
        public int MagicDefense { get { return _magicDefense; } set { _magicDefense = value; } }
        public int CritChance { get { return (int)(0.2 * _dexterity); } set { _critChanсe = value; } }
        public int CritDamage { get { return _dexterity; } set { _critDamage = value; } }
        public Hero(string name)
        {
            _name = name;
        }
    }
}
