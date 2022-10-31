using System;
namespace DateofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the day: ");
            var day = Console.ReadLine();
                switch (day.ToLower())
                {
                    case "monday":
                        Console.WriteLine($"{day} is Weekday");
                        break;
                    case "tuesday":
                        Console.WriteLine($"{day} is Weekday");
                        break;
                    case "wednesday":
                        Console.WriteLine($"{day} is Weekday");
                        break;
                    case "thursday":
                        Console.WriteLine($"{day} is Weekday");
                        break;
                    case "friday":
                        Console.WriteLine($"{day} is Weekday");
                        break;
                    case "saturday":
                        Console.WriteLine($"{day} is Weekend");
                        break;
                    case "sunday":
                        Console.WriteLine($"{day} is Weekend");
                        break;
                    default:
                        Console.WriteLine("Enter the day in correct format!");
                        break;
                }
        }
    }
}