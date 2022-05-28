using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main()
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 5;
                        break;
                }
            }
            else if (age >= 19 && age <= 64)
            {
                switch (dayType)
                {
                    case "Weekday":
                        price = 18;
                        break;
                    case "Weekend":
                        price = 20;
                        break;
                    case "Holiday":
                        price = 12;
                        break;
                }
            }
            else if (age >= 65 && age <= 122)
            {
                switch (dayType)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 10;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }

            if (age >= 0 && age <= 122)
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
