using AbstractFactory.Magician;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FlyingMagician
{
    internal class FlyingBlackMagician: IFlyingMagician
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int FlightSpeed { get; set; }

        public FlyingBlackMagician()
        {
            Health = 80;
            Damage = 10;
            FlightSpeed = 50;
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
