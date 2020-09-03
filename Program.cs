using System;
using System.Collections.Generic;
using System.Globalization;

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
            fxs.BatteryKWh = 8;
            fxs.Range = 70;
            fxs.MilesDriven = 44;
            fxs.CurrentCharge();
            // passed through (Vehicle aVehicle) as paramaters to get access to the paraent property of color 
            //and then a string to capture the name of this instance... imsure there was a better way to do that.
            fxs.Drive(fxs, "fxs");
            //pass through the turn direction as a string
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();

            Zero fx = new Zero();
            fx.MainColor = "Indigo";
            fx.MaximumOccupancy = "2";
            fx.BatteryKWh = 5.8;
            fx.Range = 50;
            fx.MilesDriven = 10;
            fx.CurrentCharge();
            // passed through (Vehicle aVehicle) as paramaters to get access to the paraent property of color 
            //and then a string to capture the name of this instance... imsure there was a better way to do that.
            fx.Drive(fx, "fx");
            //pass through the turn direction as a string
            fx.Turn("right");
            fx.Stop();
            Console.WriteLine();

            Tesla modelS = new Tesla();
            modelS.MainColor = "Yellow";
            modelS.MaximumOccupancy = "1 ego";
            modelS.BatteryKWh = 20;
            modelS.MilesDriven = 200;
            modelS.Range = 348;
            modelS.CurrentCharge();
            modelS.Drive(modelS, "modelS");
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();

            List<IElectricVehicle> IElectricVehicles = new List<IElectricVehicle>()
            {
                fx,
                fxs,
                modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in IElectricVehicles)
            {
                Console.WriteLine($"After driving {ev.MilesDriven} miles the current charge of your {ev.BatteryKWh}KWh battery is " + ev.CurrentChargePercentage.ToString("P", CultureInfo.InvariantCulture));

            }

            Console.WriteLine("..... Charging all Batteries, CLEAR!");
            foreach (IElectricVehicle ev in IElectricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in IElectricVehicles)
            {
                Console.WriteLine($"Here they are after charging " + ev.CurrentChargePercentage.ToString("P", CultureInfo.InvariantCulture));
            }

            /***********************************************/

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White w. stripes";
            mx410.MaximumOccupancy = "2 and a jumper";
            mx410.FuelCapacity = 100;
            mx410.Range = 1200;
            mx410.MilesTraveled = 350;
            mx410.CurrentFuelTankLevel();
            mx410.Drive(mx410, "mx410");
            mx410.Turn("direction");
            mx410.Stop();
            Console.WriteLine();

            Ram x1600 = new Ram();
            x1600.MainColor = "Grey";
            x1600.MaximumOccupancy = "the family";
            x1600.FuelCapacity = 40;
            x1600.Range = 350;
            x1600.MilesTraveled = 210;
            x1600.CurrentFuelTankLevel();
            x1600.Drive(x1600, "x1600");
            x1600.Turn("direction");
            x1600.Stop();
            Console.WriteLine();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                mx410,
                x1600
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"After traveling {gv.MilesTraveled} miles your {gv.FuelCapacity}gallons fuel tank has " + gv.CurrentTankPercentage.ToString("P", CultureInfo.InvariantCulture) + " remaining.");
            }

            Console.WriteLine("..... I said quit Smokin , im gonna start fueling these thangs up");
            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Here they are after fueling " + gv.CurrentTankPercentage.ToString("P", CultureInfo.InvariantCulture));
            }
        }
    }
}