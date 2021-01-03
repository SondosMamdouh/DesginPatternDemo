using System;
using System.Collections.Generic;

namespace InterpreterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwhich = new Sandwitch(
                new WheatBread(),
                new CondimentList(
                    new List<Condiment> { new MayoCondiment(), new MustardCondiment() }),
                new IngrediantList(
                    new List<Ingrediant> { new LettuceIngrediant(), new ChickenIngrediant() }),
                new CondimentList(new List<Condiment> { new KetchupCondiment() }),
                new WheatBread());

            sandwhich.Interpret(new Context());
            Console.ReadKey();
        }
    }
}
