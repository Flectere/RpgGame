using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Wizard : Hero
    {
        public override int Power
        {
            get { return _power; }
            set
            {
                _power = value;
                Health = (int)(1.4 * _vitality + 0.2 * _power);
                Damage = (int)(0.5 * _power);
            }
        }
        public override int Intelligence
        {
            get { return _intelligence; }
            set
            { 
                _intelligence = value;
                Mana = (int)(1.5 * _intelligence);
                MagicDamage =  _intelligence;
                MagicDefense = _intelligence;
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
            }
        }
        public Wizard(string name) : base(name)
        {
            _levelPoints = 0;
            _level = 0;
            _power = 15;
            _intelligence = 35;
            _dexterity = 20;
            _vitality = 15;
            StarPoints = 0;
        }
    }
}
