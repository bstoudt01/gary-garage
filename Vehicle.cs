using System;

namespace gary_garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive(Vehicle aVehicle, string vehicleName)
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine("Then it came around the outside");
        }

        public virtual void Stop()
        {
            Console.WriteLine("And the vehicle came to a low and slow stop right infront of the Bar");

        }
    }

}