using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.Factories
{
    class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var bmw = new BMW();
            bmw.SetName("BMW S ");

            return bmw;
        }
    }
}
