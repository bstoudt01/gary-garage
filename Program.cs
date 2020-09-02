using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Black";
            fxs.MaximumOccupancy = "2";
            fxs.BatteryKWh = 42.24;
            fxs.Drive(fxs);

            Tesla modelS = new Tesla();
            modelS.MainColor = "Yellow";
            modelS.MaximumOccupancy = "1 ego";
            modelS.BatteryKWh = 42.24;
            modelS.Drive(modelS);

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White w. stripes";
            mx410.MaximumOccupancy = "2 and a jumper";
            mx410.FuelCapacity = 100;
            mx410.Drive(mx410);

            Ram x1600 = new Ram();
            x1600.MainColor = "Grey";
            x1600.MaximumOccupancy = "the family";
            x1600.FuelCapacity = 40;
            x1600.Drive(x1600);

        }
    }
}