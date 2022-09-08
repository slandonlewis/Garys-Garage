using System;

namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Ram growls by you. Rrrrruuuummmmmbbbble!");
        }
    }
}