using System.Collections.Generic;

namespace TheBuilderDemo
{
    public class ClubSandwichBuilder:SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
        }

        public override void ApplyVegtables()
        {
            sandwich.Vegtables = new List<string> { "Tomato", "Onion" ,"Lettus"};
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.CheeseType = CheeseType.Mozzarella;
            sandwich.MeatType = MeateType.Turkey;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = true;

        }
    }
}