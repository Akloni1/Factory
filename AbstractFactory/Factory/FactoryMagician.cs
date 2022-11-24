using AbstractFactory.Magician;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal static class FactoryMagician
    {
        public static IMagician CreateMagician(string type)
        {
            if (type.Equals("Белый маг"))
            {
                return new WhiteMagician();
            }
            else if (type.Equals("Черный маг"))
            {
                return new BlackMagician();

            }
            else return null;
        }
    }
}
