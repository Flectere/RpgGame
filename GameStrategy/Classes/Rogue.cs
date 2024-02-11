using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GameStrategy.Classes
{
    public class Rogue : Hero
    {
        public override int Power { get { return _power; } 
            set 
            {
                _power = value;
                Damage = (int)(0.5 * _power + 0.5 * _dexterity);
                Health = (int)(1.5 * _vitality + 0.5 * _power);
            }
        }

        public override int Intelligence { get { return _intelligence; } 
            set
            {
                _intelligence = value;
                Mana = (int)(1.2 * _intelligence);
                MagicDamage = (int)(0.2 * _intelligence);
                MagicDefense = (int)(0.5 * _intelligence);
            }
        }
        public override int Dexterity { get { return _dexterity; }
            set
            {
                _dexterity = value; 
                Armor = (int)(1.5 * _dexterity);
            }
        }
        public override int Vitality { get { return _vitality; } 
            set 
            { 
                _vitality = value;
                Health = (int)(1.5 * _vitality + 0.5 * _power);
            } 
        }
        public Rogue(string name) : base(name)
        {
            LevelPoints = 0;
            Level = 0;
            Power = 20;
            Intelligence = 15;
            Dexterity = 30;
            Vitality = 20;
            StarPoints = 0;
        }
    }
}