using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int backIn30Min = 30;

            int timeInMin = hours * 60 + minutes + backIn30Min;            
            int newHour = timeInMin /60;
            int newMin = timeInMin % 60;

            if (newHour <= 23)
            {
                if (newMin < 10)
                {
                    Console.WriteLine($"{newHour}:0{newMin}");
                }
                else
                {
                    Console.WriteLine($"{newHour}:{newMin}");
                }
            }
            else
            {
                if (newMin < 10)
                {
                    Console.WriteLine($"0:0{newMin}");
                }
                else
                {
                    Console.WriteLine($"0:{newMin}");
                }
            }
        }
    }
}
