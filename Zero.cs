using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
    {

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Zero zips by you. Yeeeeeeeoooooowwww!");
        }
    }
}