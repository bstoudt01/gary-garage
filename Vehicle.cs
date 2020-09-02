using System;

namespace gary_garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        //requires 2 arguments to be passed in
        public virtual void Drive(Vehicle aVehicle, string vehicleName)
        {
            Console.WriteLine($"The {aVehicle} {vehicleName} went by all like VrooOOOOOoooommmmmm!.....");
        }

        //requires 1 argument to be passed in
        public virtual void Turn(string direction)
        {
            Console.WriteLine("Then it came around the outside");
        }

        //requires no arguments to be passed in
        public virtual void Stop()
        {
            Console.WriteLine("And the vehicle came to a low and slow stop right infront of the Bar");

        }
    }

}