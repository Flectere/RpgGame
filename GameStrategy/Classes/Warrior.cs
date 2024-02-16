using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Warrior : Hero
    {
        public override int Power
        {
            get { return _power; }
            set
            {
                _power = value + weapon.power;
                Health = (int)(2 * _vitality +  _power);
                Damage = _power;
                if (weapon != null)
                {
                    _power += weapon.power;
                }
            }
        }

        public override int Intelligence{ get { return _intelligence; }
            set
            { 
                _intelligence = value;
                Mana = _intelligence;
                MagicDamage = (int)(0.2 * _intelligence);
                MagicDefense = (int)(0.5 * _intelligence);
            }
        }

        public override int Dexterity 
        { 
            get { return _dexterity; } 
            set 
            { 
                _dexterity = value;
                Armor = _dexterity;
            }
        }

        public override int Vitality 
        { 
            get { return _vitality; } 
            set 
            { 
                _vitality = value;
                Health = (int)(2 * _vitality + _power);
            }
        }

        public Warrior(string name) : base(name)
        {
            LevelPoints = 0;
            Level = 0;
            Power = 30;
            Intelligence = 10;
            Dexterity = 15;
            Vitality = 20;
            StarPoints = 0;
        }
    }
}