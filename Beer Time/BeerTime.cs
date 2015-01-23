using System;
using System.Globalization;
    class BeerTime
    {
        static void Main()
        {
            /*A beer time is after 1:00 PM and before 3:00 AM.
             *Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in 
             *range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the 
             * definition above or invalid time if the time cannot be parsed. 
             * Note: You may need to learn how to parse dates and times.*/
            Console.Write("Enter a time (in format hh:mm tt(am or pm)): ");
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime time;
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            string dateString = Console.ReadLine();

            if (DateTime.TryParseExact(dateString, "h:mm tt", enUS,DateTimeStyles.None, out time))
            {
                if (time > startTime || time < endTime)
                {
                    Console.WriteLine("YEY!!!BEER TIME!!!");
                }
                else
                {
                    Console.WriteLine("BOOOO!!!NON BEER TIME :(");
                }
            }
            else
            {
                Console.WriteLine("Invalid time!");
            }
        }
    }
