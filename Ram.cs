using System;

namespace gary_garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double MilesTraveled { get; set; }
        public double CurrentTankPercentage { get; set; }
        public double Range { get; set; }
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            MilesTraveled = 0;
            CurrentFuelTankLevel();
        }

        public void CurrentFuelTankLevel()
        {

            double fuelUsed = (FuelCapacity / Range) * MilesTraveled;
            CurrentTankPercentage = 1 - (fuelUsed / FuelCapacity);
        }
        public override void Drive(Vehicle aVehicle, string vehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Dodge Ram GRRRRRRRRRed Past as its rummmmmbbblle shook the ground!");
        }
    }
}