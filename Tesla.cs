using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric  // Electric car
    {
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Tesla blazes by you. MMmmmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Tesla squeals around a {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} silently stops as if it never moved.");
        }
    }
}