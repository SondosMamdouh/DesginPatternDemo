using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDemo
{
    public interface Expression
    {
        void Interpret(Context context);
    }

    public class Context
    {
        public string Output { get; set; }
    }


    public class Sandwitch : Expression
    {
        private readonly Bread topBread;
        private readonly CondimentList topCondiment;
        private readonly IngrediantList ingrediants;
        private readonly CondimentList bottomCondiment;
        private readonly Bread bottomBread;

        public Sandwitch(Bread topBread, CondimentList topCondiment, IngrediantList ingrediants, CondimentList bottomCondiment, Bread bottomBread)
        {
            this.topBread = topBread;
            this.topCondiment = topCondiment;
            this.ingrediants = ingrediants;
            this.bottomCondiment = bottomCondiment;
            this.bottomBread = bottomBread;
        }


        public void Interpret(Context context)
        {
            context.Output += "|";
            topBread.Interpret(context);
            context.Output += "|";
            context.Output += "<--";
            topCondiment.Interpret(context);
            context.Output += "-";
            ingrediants.Interpret(context);
            context.Output += "-";
            bottomCondiment.Interpret(context);
            context.Output += "-->";
            context.Output += "|";
            bottomBread.Interpret(context);
            context.Output += "|";
            Console.WriteLine(context.Output);
        }
    }

    public class IngrediantList : Expression
    {
        private readonly List<Ingrediant> ingrediants;
        public IngrediantList(List<Ingrediant> ingrediants)
        {
            this.ingrediants = ingrediants;
        }
        public void Interpret(Context context)
        {
            foreach (var ingrediant in ingrediants)
            {
                ingrediant.Interpret(context);
            }
        }
    }

    public interface Ingrediant:Expression
    {
    }

    public class TomatoIngrediant : Ingrediant
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format("{0}", "Tomato");
        }
    }

    public class LettuceIngrediant : Ingrediant
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format("{0}", "Lettuce");
        }
    }
    public class ChickenIngrediant : Ingrediant
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format("{0}", "Chicken");
        }
    }

    public class CondimentList : Expression
    {
        private readonly List<Condiment> condiments;
        public CondimentList(List<Condiment> condiments)
        {
            this.condiments = condiments;
        }
        public void Interpret(Context context)
        {
            foreach (var condiment in condiments)
            {
                condiment.Interpret(context);
            }
        }
    }

    public interface Condiment:Expression
    {
    }


    public class MayoCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format("{0}", "Mayo");
        }
    }

    public class MustardCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format("{0}", "Mustard");
        }
    }

    public class KetchupCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format("{0}", "Ketchup");
        }
    }


    public interface Bread:Expression
    { }

    public class WhiteBread : Bread
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format("{0}", "Whit-Bread");
        }
    }


    public class WheatBread : Bread
    {
        public void Interpret(Context context)
        {
            context.Output += string.Format("{0}", "Wheat-Bread");
        }
    }
}
