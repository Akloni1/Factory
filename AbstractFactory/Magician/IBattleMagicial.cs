using AbstractFactory.FlyingMagician;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Magician
{
    internal interface IBattleMagicial
    {
        public void Battle(IFlyingMagician flyingMagician);
    }
}
