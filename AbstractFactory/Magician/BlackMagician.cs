using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Magician
{
    internal class BlackMagician : IMagician
    {
        public int Health { get; set; }
        public int Damage { get; set; }

        public BlackMagician()
        {
            Health = 90;
            Damage = 15;
        }

        public void Confirmation()
        {
            Console.WriteLine("that's right");
        }

        public void Negative()
        {
            Console.WriteLine("no way");
        }

        public void Encouragement()
        {
            Console.WriteLine("excellent");
        }
    }
}
