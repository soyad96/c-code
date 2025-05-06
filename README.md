   public   class Titan:Aot
    {
        private string titanName;
        private string titanType;
        private string power;
        public string TianName
        {
            get { return this.titanName;  }
            set { this.titanName = value; }
        }
        public string TitanType
        {
            get { return this.titanType; }
            set { this.titanType = value; }
        }
        public string Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
        public Titan() : base()
        {

        }
        public Titan(string epName,int epNo,string titanName,string titanType,string power):base(epName,epNo)
        {
            this.titanName = titanName;
            this.titanType = titanType;
            this.power = power;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" the name of the titan is " + this.titanName);
            Console.WriteLine(" the titan type is " + this.titanType);
            Console.WriteLine(" the titan has " + this.power);
        }

    }
}
