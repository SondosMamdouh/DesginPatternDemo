using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = Console.ReadLine();

            AutoFactory autoFactory = new AutoFactory();
            IAuto auto = autoFactory.CreateInstance(carName);
            auto.TurnOn();
            auto.TurnOff();
        }
    }
}
