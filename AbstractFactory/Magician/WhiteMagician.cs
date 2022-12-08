using AbstractFactory.FlyingMagician;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Magician
{
    internal class WhiteMagician: IMagician
    {
        public int Health { get; set; }
        public int Damage { get; set; }

        public WhiteMagician()
        {
            Health = 100;
            Damage = 10;
        }

        public void Confirmation()
        {
            Console.WriteLine("Так точно");
        }

        public void Negative()
        {
            Console.WriteLine("Никак нет");
        }

        public void Encouragement()
        {
            Console.WriteLine("Отлично");
        }

        public void Battle(IFlyingMagician flyingMagician)
        {
            flyingMagician.Health = flyingMagician.Health - 20;
        }
    }
}
