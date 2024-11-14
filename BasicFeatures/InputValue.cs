using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFeatures
{
    public class InputValue
    {
        public static void ConsoleReadlines()
        {
            bool success = true;
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            while (success)
            {
                Console.WriteLine("What's your age?");
                string age = Console.ReadLine();
                if (int.TryParse(age, out int thisAge))
                {
                    success = false;
                    //Different string concantation
                    Console.WriteLine(string.Concat("Your name is ", name, " and your age is ", thisAge));
                    Console.WriteLine($"Your name is {name} and your age is  {thisAge}");  //My best
                    Console.WriteLine("Your name is {0} and your age is {1}", name, thisAge);
                }
                else
                    Console.WriteLine("Invalid age");

            }
        }

        public static void NumberFormatting()
        {
            double dec = 1000D / 12.34;
            Console.WriteLine(dec);
            Console.WriteLine(string.Format("{0:0}", dec));
            Console.WriteLine(string.Format("{0:0.0}", dec));
            Console.WriteLine(string.Format("{0:0.00}", dec));
            Console.WriteLine(string.Format("{0:0.000}", dec));

            double money = -10D / 3D;
            Console.WriteLine(money);
            Console.WriteLine(money.ToString("C")); //default two decimal places
            Console.WriteLine(money.ToString("C0"));// 0 decimal places
            Console.WriteLine(money.ToString("C1")); // 1 decimal place
            Console.WriteLine(money.ToString("C2"));  // 2 decimal places

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));  // 2 decimal places
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("")));
            Console.WriteLine(string.Format("KES {0:N3}", money));
        }

        public static void WorkingOnDate()
        {
            // 2015 is year, 12 is month, 25 is day
            DateTime date1 = new DateTime(2015, 12, 25);
            string date1Str = date1.ToString(); 
            Console.WriteLine(date1Str); // 12/25/2015 12:00:00 AM

            // 2015 - year, 12 - month, 25 – day, 10 – hour, 30 – minute, 50 - second
            DateTime date2 = new(2012, 12, 25, 10, 30, 50);
            Console.WriteLine(date1.ToString());// 12/25/2015 10:30:00 AM }

            // Creating TimeSpan object of one month(as 30 days)
            TimeSpan duration = new(30, 0, 0, 0);
            DateTime newDate1 = DateTime.Now.Add(duration);
            Console.WriteLine(newDate1); // 1/19/2016 11:47:52 AM

            // Adding days to a date
            DateTime today = DateTime.Now; // 12/20/2015 11:48:09 AM
            DateTime newDate2 = today.AddDays(30); // Adding one month(as 30 days)
            Console.WriteLine(newDate2); // 1/19/2016 11:48:09 AM

            // Parsing
            string dateString = "Wed Dec 30, 2015";
            DateTime dateTime12 = DateTime.Parse(dateString); // 12/30/2015 12:00:00 AM

            // Date Difference
            DateTime date4 = new(2015, 3, 10, 2, 15, 10);
            DateTime date5 = new(2015, 7, 15, 6, 30, 20);
            DateTime date3 = new(2015, 12, 28, 10, 45, 30);

            // diff1 gets 127 days, 04 hours, 15 minutes and 10 seconds.
            TimeSpan diff1 = date2.Subtract(date1); // 127.04:15:10
                                                    // date4 gets 8/23/2015 6:30:20 AM
            DateTime date6 = date3.Subtract(diff1);
            // diff2 gets 166 days 4 hours, 15 minutes and 10 seconds.
            TimeSpan diff2 = date3 - date2; //166.04:15:10
                                            // date5 gets 3/10/2015 2:15:10 AM
            DateTime date7 = date2 - diff1;

            // Universal Time
            DateTime dateObj = new(2015, 12, 20, 10, 20, 30);
            Console.WriteLine("mans" + dateObj.ToUniversalTime()); // 12/20/2015 4:50:30 AM
        }
    }
}
