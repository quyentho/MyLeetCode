using System;
using System.Linq;

namespace _27._Remove_Element
{
    // https://leetcode.com/problems/remove-element/
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            Console.WriteLine(RemoveElement2(input1, 2));
            input1.ToList().ForEach(num => Console.Write($"{num} "));
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }

        public static int RemoveElement2(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length - 1;

            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n];

                    n--;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }
    }
}
