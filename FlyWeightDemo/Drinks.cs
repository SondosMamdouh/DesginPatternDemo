using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightDemo
{
    public interface IDrinkFlyweight
    {
        string Name { get; }
        void Serve(string size);
    }

    public class Espresso : IDrinkFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }
        private IEnumerable<string> _ingredients;

        public Espresso()
        {
            _name = "Espresso";
            _ingredients = new List<string>()
            { "Coffee Beans",
            "Hot Water"};
        }
        public void Serve(string size)
        {
            Console.WriteLine($"-{_name} {size} with {string.Join(", ",_ingredients)} comming up!");
        }
    }


    public class BananaSmothie : IDrinkFlyweight
    {
        private string _name;
        public string Name { get { return _name; } }
        private IEnumerable<string> _ingredients;
        public BananaSmothie()
        {
            _name = "Banana Smoothie";
            _ingredients = new List<string>()
            {
                "Banana",
                "Whole Milk",
                "Vanilla Extract"
            };
        }
        public void Serve(string size)
        {
            Console.WriteLine($"- {_name} {size} with {string.Join(", ", _ingredients)} comming up!");
        }
    }

    public class DrinkGiveaway : IDrinkFlyweight
    {
        private string _name;
        public string Name { get { return ""; } }
        private IDrinkFlyweight[] _eligibleDrinks = new IDrinkFlyweight[]
        {
            new Espresso(),
            new BananaSmothie()
        };

        private IDrinkFlyweight _randomDrink;
        private string _size;

        public DrinkGiveaway()
        {
            var randomIndex = new Random().Next(0, 2);
            _randomDrink = _eligibleDrinks[randomIndex];
        }
        public void Serve(string size)
        {
            _size = size;
            Console.WriteLine($"Free Giveaway!");
            Console.WriteLine($"- {_size} {_randomDrink.Name} coming up!");
        }
    }
}
