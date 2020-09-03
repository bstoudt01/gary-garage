namespace gary_garage
{
    public interface IElectricVehicle
    {
        double MilesDriven { get; set; }
        double BatteryKWh { get; set; }

        void ChargeBattery();

        double CurrentChargePercentage { get; set; }
        void CurrentCharge();
    }
}