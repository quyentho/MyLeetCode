using System;
using System.Linq;

namespace _1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    // https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 6, 5, 4, 8 };
            int[] result = SmallerNumbersThanCurrent(nums);
            result.ToList().ForEach(num => Console.Write($"{num} "));
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i && nums[j] < nums[i])
                    {
                        result[i]++;
                    }
                }
            }
            return result;
        }
    }
}

