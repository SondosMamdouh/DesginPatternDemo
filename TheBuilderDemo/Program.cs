using System;
using System.Collections.Generic;
using static TheBuilderDemo.Sandwich;

namespace TheBuilderDemo
{
    public class Sandwich
    {
        public Sandwich()
        {
        }

        public bool IsToasted { get; internal set; }
        public bool HasMayo { get; internal set; }
        public CheeseType CheeseType { get; internal set; }
        public BreadType BreadType { get; internal set; }
        public List<string> Vegtables { get; internal set; }
        public MeateType MeatType { get; internal set; }

        public void Display()
        {
            Console.WriteLine("Sandwitch on {0} Bread",BreadType);
            if(IsToasted)
                Console.WriteLine("Toasted");
            if (HasMayo)
                Console.WriteLine("with Mayo");
            Console.WriteLine("Sandwitch on {0} Meat", MeatType);
            Console.WriteLine("Sandwitch on {0} Cheese", CheeseType);
            Console.WriteLine("vegies: ");
            foreach (var item in Vegtables)
            {
                Console.WriteLine(" {0}", item);
            }

        }
    }
    public enum BreadType
    {
        White,
        Bruan
    }
    public enum CheeseType
    {
        Chedder,
        Mozzarella
    }

    public enum MeateType
    {
        Beef,
        Turkey
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich1 = new SandwichMaker(new MySandwichBuildr());
            sandwich1.BuildSandwich();
            sandwich1.GetSandwich().Display();

            var sandwich2 = new SandwichMaker(new ClubSandwichBuilder());
            sandwich2.BuildSandwich();
            sandwich2.GetSandwich().Display();
        }
    }

   
}
