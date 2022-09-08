using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} flashes by you like a hurricane. Zoooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
}