using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EnergyMonitor
{
     public class AC:Appilance
    {
        private int btu;
        private int starRating;
        public int Btu
        {
            get { return this.btu; }
            set { this.btu = value; }
        }
        public int StarRating
        {
            get { return this.starRating; }
            set { this.starRating = value; }
        }
        public AC()
        {

        }
        public AC(string applianceName, string brand,int btu,int starRating):base(applianceName, brand)
        {
            this.btu = btu;
            this.starRating = starRating;
        }
        public  override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(" the btu is " + this.btu);
            Console.WriteLine(" the ac rating is  " + this.starRating);
        }
        public double MonthlyElectricityBill(int hours)
        {
            return this.btu * hours * 0.05*30;
        }
        public double MonthelyElectricityBill(int hours,double unitCoast)
        {
            double totalunitcoast = hours * unitCoast*30;
            return totalunitcoast;
        }
        public bool IsEcoFriendly()
        {
            if (this.starRating >= 4) return true;
            else return false;
        }
    }
}
