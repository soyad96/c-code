using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyMonitor
{
    public  class Appilance
    {
        protected string applianceName;
        protected string brand;
        protected static double totalEnergyUsed;
        public String ApplianceName
        {
            get { return this.applianceName; }
            set { this.applianceName = value; }
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public static double TotalEnergyUsed
        {
            get { return totalEnergyUsed; }
            set { totalEnergyUsed = value; }
        }
        public Appilance()
        {
            
        }
        public Appilance(string applianceName,string brand)
        {
            this.applianceName = applianceName;
            this.brand = brand;
            
        }
        public virtual  void ShowDetails()
        {
            Console.WriteLine();

            Console.WriteLine(" the appliance details you want thank you ");
            Console.WriteLine(" the appliance name is" + this.applianceName);
            Console.WriteLine(" the brand is " + this.brand);
         
            Console.WriteLine(" the total engergy used " + Appilance.totalEnergyUsed);
        }
    }
}
