namespace gary_garage
{
    public interface IGasVehicle
    {
        double MilesTraveled { get; set; }
        double CurrentTankPercentage { get; set; }
        double FuelCapacity { get; set; }

        void RefuelTank();

    }
}