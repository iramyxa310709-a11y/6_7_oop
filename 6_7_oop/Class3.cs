namespace _6_7_oop
{
    class Class3
    {
        static void Modify(ref int extra, ref string str, ref Class1 f)
        {
            extra++;
            f.Volume++;
            f.Power++;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=========================================");
            Console.WriteLine("\tМОРОЗИЛЬНІ КАМЕРИ\t");
            Console.WriteLine("=========================================");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("--- 1. Створення об'єкта ---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Class1 f = new Class1("Полар", 340, -23.5);
            f.Color = "Білий";
            Console.WriteLine(f);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("--- 2. Робота з властивостями ---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            f.Volume = 400;
            Console.WriteLine($"  Новий об'єм : {f.Volume} л");
            f.Temperature = 25;
            Console.WriteLine($"  Температура після некоректного значення (25) : {f.Temperature} градусів");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("--- 3. Методи управління і доступу ---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            f.SetTemperature(-30);
            f.SetPower(215);
            Console.WriteLine($"  Марка\t: {f.GetBrand()}");
            Console.WriteLine($"  Температура : {f.GetTemperature()} градусів");
            Console.WriteLine($"  Потужність  : {f.GetPower()} Вт");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("--- 4. Передача аргументів за посиланням ---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int extra = 5;
            string str = "опис";
            Console.WriteLine("до:");
            Console.WriteLine($"  Число : {extra}");
            Console.WriteLine($"  Рядок : {str}");
            Console.WriteLine($"  Об'єм : {f.Volume} л. Потужність : {f.Power} Вт");
            Modify(ref extra, ref str, ref f);
            Console.WriteLine("після:");
            Console.WriteLine($"  Число : {extra}");
            Console.WriteLine($"  Рядок : {str}");
            Console.WriteLine($"  Об'єм : {f.Volume} л. Потужність : {f.Power} Вт");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("--- 5. Масив морозильних камер ---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Class1[] freezers = new Class1[6];
            freezers[0] = new Class1();
            freezers[1] = new Class1("Норд");
            freezers[2] = new Class1("Сніг", 210);
            freezers[3] = new Class1("Мороз", 275, -25.5);
            freezers[4] = new Class1("Лід", 120, -15);
            freezers[5] = new Class1("Холод", 520, -35.5);
            freezers[5].Color = "Чорний";

            int number = 1;
            foreach (var item in freezers)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[ Камера {number} ]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item);
                Console.WriteLine();
                number++;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==================================================");
            Console.WriteLine($"всього створено камер : {f.GetCount()}");
            Console.WriteLine("==================================================");
        }
    }
}