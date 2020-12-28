using System;

namespace FactoryMethodDemo
{
    public interface IAuto
    {
        string Name { get; }
        void SetName(string name);
        void TurnOn();
        void TurnOff();

    }
    public class BMW : IAuto
    {
        public BMW()
        {
        }
        public string Name { get; private set; }
        public void SetName(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
        }

        public void TurnOff()
        {
            Console.WriteLine("The" + Name + "is up and running...");
        }

        public void TurnOn()
        {
            Console.WriteLine("The" + Name + "is shutting down...");
        }
    }
}