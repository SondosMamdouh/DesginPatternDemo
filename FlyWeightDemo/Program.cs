using System;

namespace FlyWeightDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinkFactory = new DrinkFactory();

           /*  var largeExpresso = drinkFactory.GetDrink("Espresso");
              largeExpresso.Serve("Large");

              var mediumSmoothie = drinkFactory.GetDrink("BananaSmoothie");
              mediumSmoothie.Serve("Medium");

              var smallEspresso = drinkFactory.GetDrink("Espresso");
              smallEspresso.Serve("Small");
           
              drinkFactory.ListDrinks();*/

            var sizes = new string[] { "Small", "Medium", "Large" };
            foreach (var size in sizes)
            {
                var giveaway = drinkFactory.CreateGaveaway();
                giveaway.Serve(size);
            }
        }
    }
}
