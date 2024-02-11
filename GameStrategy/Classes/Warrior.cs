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
                _power = value;
                Health = (int)(2 * _vitality +  _power);
            }
        }
        public override int Intelligence
        {
            get { return _intelligence; }
            set
            { 
                _intelligence = value;
                Mana = _intelligence;
                MagicDamage = (int)(0.2 * _intelligence);
                MagicDefense = (int)(0.5 * _intelligence);
            }

        }
        public override int Dexterity { get { return _dexterity; } 
            set 
            { 
                _dexterity = value;
                Armor = _dexterity;
            } 
        }
        public override int Vitality { get { return _vitality; } set { _vitality = value; } }
        public Warrior(string name) : base(name)
        {
            _levelPoints = 0;
            _level = 0;
            _power = 30;
            _intelligence = 10;
            _dexterity = 15;
            _vitality = 25;
            StarPoints = 0;
        }
    }
}
