using System;

namespace gary_garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double Range { get; set; }
        public double MilesDriven { get; set; }
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            MilesDriven = 0;
            CurrentCharge();
        }

        public void CurrentCharge()
        {

            double batteryUsed = (BatteryKWh / Range) * MilesDriven;
            CurrentChargePercentage = 1 - (batteryUsed / BatteryKWh);
        }

        public override void Drive(Vehicle aVehicle, string vehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Tesla ghosted past like a fart in the wind!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Telsa took a {direction} from the stop sign");
        }
    }
}