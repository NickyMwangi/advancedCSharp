using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFeatures
{
    public class ListExercises
    {
        public static void TenTimesTable()
        {
            Console.WriteLine("Write a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} x {1} = {2}", i, num, i * num);
        }

        public static void FizzBuzzGame()
        {
            for(int i = 1;i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        public static void ReverseString()
        {
            string str = "C# is an awesome language";

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                Thread.Sleep(100);
            }

            //reverse character
            Console.WriteLine("***Diplay in Reverse***");
            for (int i = str.Length-1; i >=0; i--)
            {                                      
                Console.Write(str[i]);
                Thread.Sleep(100);
            }
        }
                                                 
        public static void PasswordChecker()
        {
            Console.WriteLine("Your Password?");
            string password = Console.ReadLine();
            Console.WriteLine("Confirm Password?");
            string ConfirmPassword = Console.ReadLine();
            if (!string.IsNullOrEmpty(password))
            {
                if (!string.IsNullOrEmpty(ConfirmPassword))
                {
                    if (password.Equals(ConfirmPassword))          
                        Console.WriteLine("Passwords match");
                    else 
                        Console.WriteLine("Passwords do not match");
                }
                else
                    Console.WriteLine("Please enter a valid confirmation password");
            }
            else
                Console.WriteLine("Please enter a valid password");
        }

        public static void OddEvenNumber()
        {
            List<int> odd =[];
            List<int> even = [];
            for(int i = 0;i <= 20; i++)
            {
                 if(i%2==0)
                    even.Add(i);
                 else
                    odd.Add(i);
            }
            Console.WriteLine("***********Printing Even Numbers");
            foreach (var item in even)
                Console.Write(item);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***********Printing Odd Numbers");
            foreach (var item in odd)
                Console.Write(item);

            Console.WriteLine();
            Console.WriteLine();
        }
        public static int CalculateArea(int width, int height)
        {
            return (width * height) / 2;
        }
    }
}
