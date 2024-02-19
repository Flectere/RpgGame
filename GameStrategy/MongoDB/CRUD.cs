using MongoDB.Driver;
using GameStrategy.Classes;
using System.Collections.Generic;
using MongoDB.Bson;
using System.Windows;
using System;
using System.Linq;

namespace GameStrategy
{
    public class CRUD
    {
        public static void CreateHero(Hero hero)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            collection.InsertOneAsync(hero);
        }
        public static List<Hero> GetHero(string type)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            var filter = Builders<Hero>.Filter.Eq("_t", type);
            var result = collection.Find(filter).ToList();
            return result;
        }
        public static void UpdateHero(Hero hero)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            var filter = Builders<Hero>.Filter.Eq(i => i._id, hero._id);
            collection.ReplaceOne(filter, hero);
        }
        public static void CreateWeapon()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Weapon>("WeaponCollection");
            List<Weapon> list = new List<Weapon>
            {
                new Wand(1),
                new Wand(2),
                new Wand(3),
                new Mace(1),
                new Mace(2),
                new Mace(3),
                new Dagger(1),
                new Dagger(2),
                new Dagger(3),
                new Sword(1),
                new Sword(2),
                new Sword(3),
                new Axe(1),
                new Axe(2),
                new Axe(3)
            };
            collection.InsertMany(list);
        }
        public static List<Weapon> GetWeapon()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Weapon>("WeaponCollection");
            List<Weapon> result = collection.Find(x => true).ToList();
            return result;
        }
    }
}