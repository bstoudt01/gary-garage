using System;

namespace gary_garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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