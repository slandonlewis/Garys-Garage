/* TESTING VEHICLE FUNCTIONS (Driving, Stopping, Turning) */

// using System;

// namespace Garage
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Midnigth Blue Zero
//             Vehicle blueZero = new Zero();
//             blueZero.MainColor = "Midnight Blue";
//             blueZero.Drive();
//             blueZero.Turn("right");
//             blueZero.Stop();
//             Console.WriteLine("");

//             // Black Zero
//             Vehicle blackZero = new Zero();
//             blackZero.MainColor = "Black";
//             blackZero.Drive();
//             blackZero.Turn("right");
//             blackZero.Stop();
//             Console.WriteLine("");

//             // Burgundy Tesla
//             Vehicle tesla = new Tesla();
//             tesla.MainColor = "Burgundy";
//             tesla.Drive();
//             tesla.Turn("right");
//             tesla.Stop();
//             Console.WriteLine("");

//             // Silver Ram
//             Vehicle ram = new Ram();
//             ram.MainColor = "Silver";
//             ram.Drive();
//             ram.Turn("right");
//             ram.Stop();
//             Console.WriteLine("");

//             // White Cessna
//             Vehicle cessna = new Cessna();
//             cessna.MainColor = "White";
//             cessna.Drive();
//             cessna.Turn("right");
//             cessna.Stop();
//             Console.WriteLine("");

//         }
//     }
// }

/* REFUELING AND RECHARGING VEHICLES */

using System;
using System.Collections.Generic;
namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            // setting battery percentages
            fxs.CurrentChargePercentage = 90;
            fx.CurrentChargePercentage = 15;
            modelS.CurrentChargePercentage = 60;

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            Console.WriteLine("*****************");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev} Battery: {ev.CurrentChargePercentage}%");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev} Battery: {ev.CurrentChargePercentage}%");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            // set maximum fuel capacity AND current fuel percentage
            ram.CurrentTankPercentage = 15;
            ram.FuelCapacity = 23;

            cessna150.CurrentTankPercentage = 5;
            cessna150.FuelCapacity = 13;

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            Console.WriteLine("*****************");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv} Fuel: {gv.CurrentTankPercentage}%");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv} Fuel: {gv.CurrentTankPercentage}%");
            }
        }
    }
}