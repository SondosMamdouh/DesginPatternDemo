using System;
using System.Collections.Generic;
using System.Text;

namespace TheBuilderDemo
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder builder;
        public SandwichMaker(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildSandwich()
        {
            builder.CreateNewSandwich();
            builder.PrepareBread();
            builder.ApplyMeatAndCheese();
            builder.ApplyVegtables();
            builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return builder.GetSandwich();
        }
    }
}
