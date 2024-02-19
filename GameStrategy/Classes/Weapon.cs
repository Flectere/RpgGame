using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    [BsonKnownTypes(typeof(Hand), typeof(Axe), typeof(Dagger), typeof(Sword), typeof(Mace), typeof(Wand))]
    public class Weapon
    {
        public ObjectId _id;
        public string NameWeapon { get; set;  }
        public int Power { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int MagicDamage { get; set; }
        public int MagicDefense { get; set; }
        public double CritChanсe { get; set; }
        public double CritDamage { get; set; }
        public bool shieldAvailable { get; set; } = true;
        public bool twoWeapon = false;
    }
}