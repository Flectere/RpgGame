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
                Health = (int)(1.5 * _vitality + 0.5 * _power);
            }
        }
        public override int Intelligence
        {
            get { return _intelligence; }
            set
            { _intelligence = value; }

        }
        public override int Dexterity { get { return _dexterity; } set { _dexterity = value; } }
        public override int Vitality { get { return _vitality; } set { _vitality = value; } }
        public Wizard(string name) : base(name)
        {
            _levelPoints = 0;
            _level = 0;
            _power = 20;
            _intelligence = 15;
            _dexterity = 30;
            _vitality = 20;
            StarPoints = 0;
            Health = (int)(1.5 * _vitality + 0.5 * _power);
            Mana = (int)(1.2 * _intelligence);
            Damage = (int)(0.5 * _power + 0.5 * _dexterity);
            Armor = (int)(1.5 * _dexterity);
            MagicDamage = (int)(0.2 * _intelligence);
            MagicDefense = (int)(0.5 * _intelligence);
            CritChance = (int)(0.2 * _dexterity);
            CritDamage = 1 * _dexterity;
        }
    }
}
