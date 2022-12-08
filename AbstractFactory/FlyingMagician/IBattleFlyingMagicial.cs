using AbstractFactory.Magician;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FlyingMagician
{
    internal interface IBattleFlyingMagicial
    {
        public void Battle(IMagician flyingMagician);
    }
}
