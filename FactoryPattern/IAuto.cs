using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
   public interface IAuto
    {
        public void TurnOn();
        public void TurnOff();
    }
    public class BMW : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("BMW iS Stopped...");
        }

        public void TurnOn()
        {
            Console.WriteLine("BMW iS Running ...");
        }
    }
    public class MiniCopper : IAuto
    {

        public void TurnOff()
        {
            Console.WriteLine("MiniCopper iS Stopped...");
        }

        public void TurnOn()
        {
            Console.WriteLine("MiniCopper iS Running ...");
        }
    }

    public class NullAuto : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("not A car ");
        }

        public void TurnOn()
        {
            Console.WriteLine("not A car ");
        }
    }
}
