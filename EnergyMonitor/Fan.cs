using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyMonitor
{
    public  class Fan:Appilance
    {
        private int bladeSize;
        private int spreedLevels;
        public int BladeSize
        {
            get { return this.bladeSize; }
            set { this.bladeSize = value; }
        }
        public int SpreedLevels
        {
            get { return this.spreedLevels; }
            set { this.spreedLevels = value; }
        }
        public Fan():base()
        {

        }
        public Fan(string applianceName, string brand,int bladeSize,int spreedLevels) : base(applianceName, brand)
        {
            this.bladeSize = bladeSize;
            this.spreedLevels = spreedLevels;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(" the fan has " + this.bladeSize);
            Console.WriteLine(" the fan has " + this.spreedLevels);
        }
        public int MaxCoolingEfficiency()
        {
            return this. bladeSize *this. spreedLevels;
        }
        public string NoiseCatagory()
        {

            if ( this.bladeSize < 10) return "Low";

            else if (this.bladeSize >= 10 && this.bladeSize <= 15) return "Midium";
            else return "high";
        }
    }
}
