using System;
using System.Collections.Generic;
using System.Text;

namespace TheBuilderDemo
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;
        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }

        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegtables();
        public abstract void AddCondiments();
    }
}
