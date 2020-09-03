using System;

namespace gary_garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive(Vehicle aVehicle, string vehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Cessna ZzzzooooooOOOOMMMED Past with!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna Banked {direction}.... \"FIRE!\" said the Pilot ");
        }

        public override void Stop()
        {
            Console.WriteLine("The Cessna came to a shot and then too was gun down and plummited to the earth.... The End");

        }
    }

}