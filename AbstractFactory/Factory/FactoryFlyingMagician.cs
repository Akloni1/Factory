using AbstractFactory.FlyingMagician;
using AbstractFactory.Magician;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal static class FactoryFlyingMagician
    {
        public static IFlyingMagician CreateMagician(string type)
        {
            if (type.Equals("Белый маг"))
            {
                return new FlyingWhiteMagician();
            }
            else if (type.Equals("Черный маг"))
            {
                return new FlyingBlackMagician();

            }
            else return null;
        }
    }
}
