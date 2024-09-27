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
            while (success) {
                Console.WriteLine("What's your age?");
                string age = Console.ReadLine();
                if (int.TryParse(age, out int thisAge)) { 
                    success = false;
                    //Different string concantation
                    Console.WriteLine(string.Concat("Your name is ", name, " and your age is ", thisAge));
                    Console.WriteLine($"Your name is {name} and your age is  {thisAge }");  //My best
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
    }
}
