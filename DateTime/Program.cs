using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a date please: ");
            string userDateString = Console.ReadLine();

            Console.Write("What day format do u want to use?");
            string dateFormat = Console.ReadLine();

            if (dateFormat.Length < 1)
            {
                dateFormat = "dd/MM/yyyy";
            }
            dateFormat.ToString();
            DateTime userDate = DateTime.ParseExact(userDateString, dateFormat, null);
            
            TimeSpan desdeUserDate = DateTime.Now.Subtract(userDate);

            if (desdeUserDate.Ticks < 0)
            {
                Console.WriteLine($" {userDateString} is {-desdeUserDate.Days} days in the future");
            }
            else
            {
                Console.WriteLine($"It has been {desdeUserDate.Days} days since {userDateString}");
            }

            Console.Write("Give me a time please: ");
            string userTimeString = Console.ReadLine();

            Console.Write("What time format do you want to use?");
            string timeFormat = Console.ReadLine();

            if (timeFormat.Length < 1)
            {
                timeFormat = "h:mm tt";
            }

            DateTime userTime = DateTime.ParseExact(userTimeString, timeFormat, null);

            TimeSpan desdeUserTime = DateTime.Now.Subtract(userTime);

            if (desdeUserTime.Ticks < 0)
            {
                desdeUserTime = desdeUserTime.Add(TimeSpan.FromHours(24));
            }

            Console.WriteLine($"{userTimeString} was {desdeUserTime.Hours} hours and {desdeUserTime.Minutes} minutes ago.");

            Console.ReadLine();
        }
    }
}
