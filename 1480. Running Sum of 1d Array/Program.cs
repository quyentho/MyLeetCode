using System;

namespace _1480._Running_Sum_of_1d_Array
{
    // https://leetcode.com/problems/running-sum-of-1d-array/

    /*  Input: nums = [1,2,3,4]
        Output: [1,3,6,10]
        Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = RunningSum(nums);
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{result[i] }");
            }
        }

        public static int[] RunningSum(int[] nums)
        {
            
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
