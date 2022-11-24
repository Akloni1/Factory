using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Magician
{
    internal interface IMagician: ICommands
    {
        public int Health { get; set; }
        public int Damage { get; set; }

    }
}
