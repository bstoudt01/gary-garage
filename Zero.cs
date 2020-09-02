using System;

namespace gary_garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive(Vehicle aVehicle, string name)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Zero {name} ziped Past like a mouse!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero Pivoted {direction}.... PIIIIVOT!!! ");
        }

        public override void Stop()
        {
            Console.WriteLine("{The Zero came to a stop and was put back into my wallet for safe keeping");

        }
    }

}