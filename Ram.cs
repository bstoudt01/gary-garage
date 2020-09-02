using System;

namespace gary_garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive(Vehicle aVehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Dodge Ram GRRRRRRRRRed Past as its rummmmmbbblle shook the ground!");
        }
    }
}