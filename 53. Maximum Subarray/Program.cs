﻿using System;

namespace _53._Maximum_Subarray
{
    // https://leetcode.com/problems/maximum-subarray/
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaxSubArray(nums));
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int max = nums[0];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int sum = 0;

                for (int j = i+1; j < nums.Length - 1; j++)
                {
                    sum += nums[j];
                    if (sum > max)
                    {
                        max = sum;
                    }       
                }
            }

            return max;
        }

        //public static int MaxSubArrayDAC(int[] nums   )
        //{
        //    if (nums.Length == 1)
        //    {
        //        return nums[0];
        //    }

            
        //}
    }
}
