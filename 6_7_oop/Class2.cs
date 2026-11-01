namespace _6_7_oop
{
    partial class Class1
    {
        public void SetVolume(int newVolume)
        {
            if (newVolume > 0)
                this.volume = newVolume;
            else
                this.volume = 0;
        }
        public void SetTemperature(double newTemp)
        {
            if (newTemp <= 0)
                this.temperature = newTemp;
            else
                this.temperature = -18;
        }
        public void SetPower(double newPower)
        {
            if (newPower > 0)
                this.power = newPower;
            else
                this.power = 0;
        }

        public string GetBrand()
        {
            return brand;
        }
        public int GetVolume()
        {
            return volume;
        }
        public double GetTemperature()
        {
            return temperature;
        }
        public double GetPower()
        {
            return power;
        }
        public int GetShelves()
        {
            return shelves;
        }
        public int GetCount()
        {
            return count;
        }

        public void Print()
        {
            Console.WriteLine($"Марка : {brand}. Об'єм : {volume} л. Температура : {temperature} градусів");
        }
        public override string ToString()
        {
            return $"  Марка\t: {Brand}\n  Об'єм\t: {Volume} л\n  Температура : {Temperature} градусів\n  Потужність\t: {Power} Вт\n  Полиць\t: {Shelves}\n  Колір\t: {Color}\n  Тип\t: {Type}\n  Виробник\t: {factory}";
        }
    }
}