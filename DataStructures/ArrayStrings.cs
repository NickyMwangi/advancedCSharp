using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class ArrayStrings
    {
        //Skip every alternate elements
        public static void SkipAlternateElements()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //traverse both ends simultanously
        public static void TraverseSimultaneouslt()
        {
            int[] arr = { 10, 20, 30, 40, 50, 60 };
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                Console.WriteLine($"Start is {arr[start]} and the End is {arr[end]}");
                start++;
                end--;
            }
        }

        // Print index and value for each element.
        public static void PrintIndexValue()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            var indexed = arr.Select((value, index) => new { value, index });
            foreach (var n in indexed)
            {
                Console.WriteLine($"Index: {n.index}, Value: {n.value}");
            }
        }

        //Sum of all elements in an array using recursion.
        public static void RecursionSum()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumArray(arr, 0));
        }

        private static int SumArray(int[] arr, int index)
        {
            if (index == arr.Length) return 0;
            return arr[index] + SumArray(arr, index + 1);
        }

        //find the maximum product of two elements in an array
        public static void MaximumProduct()
        {
            int[] arr = { 3, 5, -2, 9, -8 };
            int maxProduct = arr.Min();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    int prod = arr[i] * arr[j];
                    if (prod > maxProduct)
                        maxProduct = prod;
                }
            }
            Console.WriteLine($"Maximum product is {maxProduct}");
        }

        // Find two numbers in a sorted array that sum to a target.
        public static void SumToTarget()
        {
            int[] nums = { 1, 2, 3, 4, 6 };
            int target = 6;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int ttl = nums[i] + nums[j];
                    if (ttl == target)
                    {
                        Console.WriteLine($"The two numbers are {nums[i]} and {nums[j]} and the total is {ttl}");
                        return;
                    }
                    Console.WriteLine($"The two numbers are {nums[i]} and {nums[j]}");
                }
            }
        }

        // Move zeros to the end of an array.
        public static void MoveZeroToEnd()
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            int nonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++) { 
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    nonZeroIndex++;
                }
            }
            for (int i = nonZeroIndex; i < nums.Length; i++) {
                nums[i] = 0;
            }
            Console.WriteLine(nums.Select(n => n));
        }

        // Maximum sum of a subarray of size k.
        // Time Complexity: O(n). The Array is traversed once
        // Space Complexity O(1). Only a few variables are used for calculations
        public static void SumSubArray()
        {
            int[] nums = { 2, 1, 5, 1, 3, 2 };
            int k = 3;
            if (nums.Length < k)
                throw new ArgumentException("Array length must be greater than or equal to k.");
            int windowSum = 0;
            int maxsum = 0;
            // Compute the sum of the first window
            for (int i = 0; i < k; i++)
            {
                windowSum += nums[i];
            }
            maxsum = windowSum;


            // Slide the window across the array
            for (int i = k;i < nums.Length;i++)
            {
                windowSum += nums[i] - nums[i - k]; /// Add the new element and remove the old one
                maxsum = Math.Max(maxsum, windowSum);
            }
            Console.WriteLine($"The maximum value is {maxsum}");
        }

        //Longest substring without repeating characters.
        public static void LengthOfLongestSubstring()
        {
            string s = "abcabcbb";
            int maxLength = 0;
            int start = 0;
            var charSet = new HashSet<char>();
            for(int end=0; end < s.Length; end++)
            {
                while (charSet.Contains(s[end]))
                {
                    var strt = s[start];
                    charSet.Remove(s[start]);
                    start++;
                }
                var nd = s[end];
                charSet.Add(s[end]);
                maxLength = Math.Max(maxLength, end - start+1);
            }
            Console.WriteLine($"Maximum length is {maxLength}");
        }

        public static void LongestBinaryGap(int N)
        {
            string binary = Convert.ToString(N,2);
            int maxGap = 0;
            int currentGap = 0;
            foreach (char bit in binary)
            {
                if(bit == '1')
                {
                    maxGap = Math.Max(maxGap, currentGap); 
                    currentGap=0;
                }
                else
                {
                    currentGap++;
                }
            }
            Console.WriteLine($"Maximum gap is {maxGap}");
        }
    }
}
