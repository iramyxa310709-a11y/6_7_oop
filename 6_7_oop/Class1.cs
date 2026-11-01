namespace _6_7_oop
{
    partial class Class1
    {
       
        private string brand;
        private int volume;
        private double temperature;
        private double power;
        private int shelves;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value > 0)
                    volume = value;
                else
                    volume = 0;
            }
        }

        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (value <= 0)
                    temperature = value;
                else
                    temperature = -18;
            }
        }

        public double Power
        {
            get { return power; }
            set
            {
                if (value > 0)
                    power = value;
                else
                    power = 0;
            }
        }

        public int Shelves
        {
            get { return shelves; }
            set
            {
                if (value > 0)
                    shelves = value;
                else
                    shelves = 0;
            }
        }
        public string Color { get; set; } = "не вказано";
        public string Type { get; private set; } = "збереження";

        
        static int count;
        static string factory;

    
        static Class1()
        {
            count = 0;
            factory = "Холод";
        }

        public Class1() : this("невідомо", 100, -18) { }
        public Class1(string brand) : this(brand, 150, -18) { }
        public Class1(string brand, int volume) : this(brand, volume, -20) { }
        public Class1(string brand, int volume, double temperature)
        {
            Brand = brand;
            Volume = volume;
            Temperature = temperature;
            Power = 180;
            Shelves = 3;
            count++;
        }
    }
}