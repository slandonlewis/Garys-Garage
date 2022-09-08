using System;

namespace Garage
{
    public class Vehicle
    {
        public double BatteryKWh { get; set; } = 100;
        public double FuelCapacity { get; set; }

        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public int CurrentChargePercentage { get; set; }
        public int CurrentTankPercentage { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public void ChargeBattery()
        {
            while (CurrentChargePercentage < BatteryKWh)
            {
                CurrentChargePercentage++;
            }
        }
        public void RefuelTank()
        {
            while (CurrentTankPercentage < FuelCapacity)
            {
                CurrentTankPercentage++;
            }
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop!");
        }

    }
    public interface IElectric
    {
        int CurrentChargePercentage { get; }
        void ChargeBattery();
    }

    public interface IGas
    {
        int CurrentTankPercentage { get; }
        void RefuelTank();
    }
}