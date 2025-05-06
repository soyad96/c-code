using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Appilance ap = new Appilance();
            ap.ApplianceName = "tv";
            ap.Brand = "LG";
            Appilance.TotalEnergyUsed = 100.04;
            ap.ShowDetails();
            Appilance ap2 = new Appilance("mobile ", "apple");
            ap2.ShowDetails();
            Fan f = new Fan();
            f.ApplianceName = "Celling Fan";
            f.Brand = "city";
            f.BladeSize = 16;
            f.SpreedLevels = 34;
            f.ShowDetails();
            Console.WriteLine(" the maxcooling ability is " + f.MaxCoolingEfficiency()+"rpm");
            Console.WriteLine(f.NoiseCatagory());
            Fan f2 = new Fan(" fan ", "Philips", 9, 12);
            f2.ShowDetails();
            Console.WriteLine(" the maxcooling ability is " + f2.MaxCoolingEfficiency() + "rpm");
            Console.WriteLine(f2.NoiseCatagory());
            AC ac = new AC();
            ac.ApplianceName = "AC";
            ac.Brand = " General";
            ac.Btu = 6;
            ac.StarRating = 3;
            ac.ShowDetails();
            Console.WriteLine(" the total bill is " + ac.MonthlyElectricityBill(12));
            Console.WriteLine(ac.IsEcoFriendly());
            AC a2 = new AC("Production ac ", "LG", 120, 4);
            a2.ShowDetails();
            Console.WriteLine(" the total bill of the ac is " + a2.MonthelyElectricityBill(12, 20.50));
            Console.WriteLine(a2.IsEcoFriendly());

            Console.ReadKey();

        }
    }
}
