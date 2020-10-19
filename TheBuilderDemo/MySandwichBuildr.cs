using System;
using System.Collections.Generic;
using System.Text;

namespace TheBuilderDemo
{
    public class MySandwichBuildr:SandwichBuilder
       {
        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
        }

        public override void ApplyVegtables()
        {
            sandwich.Vegtables = new List<string> { "Tomato", "Onion" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.CheeseType = CheeseType.Chedder;
            sandwich.MeatType = MeateType.Beef;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = true;

        }
    }
}
