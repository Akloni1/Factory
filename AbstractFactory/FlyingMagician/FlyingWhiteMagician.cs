using AbstractFactory.Magician;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FlyingMagician
{
    internal class FlyingWhiteMagician : IFlyingMagician
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int FlightSpeed { get; set; }

        public FlyingWhiteMagician()
        {
            Health = 90;
            Damage = 10;
            FlightSpeed = 40;
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
    }
}
