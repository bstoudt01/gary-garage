using System;

namespace gary_garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double Range { get; set; }

        public double MilesDriven { get; set; }
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            MilesDriven = 0;
            CurrentCharge();
        }

        public void CurrentCharge()
        {

            double batteryUsed = (BatteryKWh / Range) * MilesDriven;
            CurrentChargePercentage = 1 - (batteryUsed / BatteryKWh);
        }
        //use override method to change the virtual method set by parent
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