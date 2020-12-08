using System;
using System.Linq;

namespace _1470._Shuffle_the_Array
{
    // https://leetcode.com/problems/shuffle-the-array/
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int n = 4;
            nums = Shuffle(nums, n);
            nums.ToList().ForEach(num => Console.Write($"{num} "));
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            int i = 1, j = n;
            while (i < n)
            {
                // swap
                Swap(nums, i, j);

                i++;
            }
            while (j < nums.Length - 2)
            {
                j++;
                Swap(nums, i, j);
                i++;
            }

            return nums;
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
