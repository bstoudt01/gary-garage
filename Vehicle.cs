using System;

namespace gary_garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive(Vehicle aVehicle)
        {
            Console.WriteLine("Vrooom!");
        }
    }

}