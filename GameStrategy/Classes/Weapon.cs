using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    [BsonKnownTypes(typeof(Hand))]
    public class Weapon
    {
        public int power = 0;
        public int intelligence = 0;
        public int dexterity = 0;
        public int vitality = 0;
        public int health = 0;
        public int mana = 0 ;
        public int damage = 0;
        public int armor = 0;
        public int magicDamage = 0;
        public int magicDefense = 0;
        public double critChanсe = 0;
        public double critDamage = 0;
        public bool shieldAvailable = true;
        public bool twoWeapon = false;
    }
}