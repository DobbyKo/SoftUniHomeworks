using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main()
        {
            string country = Console.ReadLine();

            string language = "";

            switch (country)
            {
                case "USA":                    
                case "England":
                    language = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}
