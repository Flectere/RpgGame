using MongoDB.Driver;
using GameStrategy.Classes;
using System.Collections.Generic;
using MongoDB.Bson;
using System.Windows;
using System;

namespace GameStrategy
{
    public class CRUD
    {
        public static void CreateHero(Hero hero, string type)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            hero._t = type;
            collection.InsertOne(hero);
        }
        public static List<Hero> GetHero(string type)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            var filter = Builders<Hero>.Filter.Eq("_t", type);
            List<Hero> result = collection.Find(filter).ToList();
            return result;
        }
        public static void UpdateRogue(Rogue rogue)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            var filter = Builders<Hero>.Filter.Eq(i => i._id, rogue._id);
            collection.ReplaceOne(filter, rogue);
        }
    }
}