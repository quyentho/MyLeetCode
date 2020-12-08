using System;
using System.Linq;

namespace _26._Remove_Duplicates_from_Sorted_Array
{
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 1, 2 };
            int[] input2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(input1));
            input1.ToList().ForEach(num => Console.Write($"{num} "));
            Console.WriteLine();
            Console.WriteLine(RemoveDuplicates(input2));
            input2.ToList().ForEach(num => Console.Write($"{num} "));

            int[] input3 = new int[0];
            RemoveDuplicates(input3);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            //if (nums.Length == 0)
            //{
            //    return 0;
            //}

            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1 ;
        }
    }
}
