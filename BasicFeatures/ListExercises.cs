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
            for (int i = 1; i <= 15; i++)
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
            for (int i = str.Length - 1; i >= 0; i--)
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
            List<int> odd = [];
            List<int> even = [];
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
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

        //Find all pairs in an array.
        public static void FindAllPairs()
        {
            int[] arr = { 1, 2, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j =0; j < arr.Length; j++)
                {
                    if (arr[j].Equals(arr[i]))
                        Console.WriteLine($"Pair: ({arr[i]}, {arr[j]})");


                    //if (!arr[j].Equals(arr[i]))
                    //    Console.WriteLine($"Pair: ({arr[i]}, {arr[j]})");
                }
            }
        }

        //Binary gap
        public static void BinaryGap(int N)
        {
            string binary = Convert.ToString(N, 2);
            int gaps = 0;
            int gapLength = 0;
            int maxgap = 0;
            foreach (char n in binary)
            {
                if (n == '1')
                {
                    gaps++;
                    maxgap = Math.Max(maxgap, gapLength);
                    gapLength = 0;
                }
                else
                {
                    gapLength++;
                }
            }
            Console.WriteLine($"Integer {N} has an equivalent binary of {binary}. This has {gaps} gaps and longest one is {maxgap}");
        }


            //Ditict string in the combination of string
        public static void TwoStringDistinct(string P, string Q)
        {
            int N = P.Length;
            int minDistinct = int.MaxValue;

            // Generate all possible combinations of S
            int totalCombinations = 1 << N; // 2^N combinations
            for (int mask = 0; mask < totalCombinations; mask++)
            {
                HashSet<char> distinctLetters = new HashSet<char>();
                for (int i = 0; i < N; i++)
                {
                    // Choose P[i] if the i-th bit of mask is 0, otherwise choose Q[i]
                    char selectedChar = ((mask & (1 << i)) == 0) ? P[i] : Q[i];
                    distinctLetters.Add(selectedChar);
                }
                // Update the minimum distinct letters
                minDistinct = Math.Min(minDistinct, distinctLetters.Count);
            }

            int maxint =  minDistinct;
        }
    }
}
