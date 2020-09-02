using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of each Parent Vehicle with a Child that included specific properties about each (child class) type
            Zero fxs = new Zero();
            fxs.MainColor = "Black";
            fxs.MaximumOccupancy = "2";
            fxs.BatteryKWh = 42.24;
            // passed through (Vehicle aVehicle) as paramaters to get access to the paraent property of color
            fxs.Drive(fxs, "fxs");
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();

            Tesla modelS = new Tesla();
            modelS.MainColor = "Yellow";
            modelS.MaximumOccupancy = "1 ego";
            modelS.BatteryKWh = 42.24;
            modelS.Drive(modelS, "modelS");
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White w. stripes";
            mx410.MaximumOccupancy = "2 and a jumper";
            mx410.FuelCapacity = 100;
            mx410.Drive(mx410, "mx410");
            mx410.Turn("direction");
            mx410.Stop();
            Console.WriteLine();

            Ram x1600 = new Ram();
            x1600.MainColor = "Grey";
            x1600.MaximumOccupancy = "the family";
            x1600.FuelCapacity = 40;
            x1600.Drive(x1600, "x1600");
            x1600.Turn("direction");
            x1600.Stop();
            Console.WriteLine();
        }
    }
}